using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static Mysqlx.Notice.Warning.Types;
using MySql.Data.MySqlClient;

namespace FashionLib
{
    public class Funcionario
    {
        // Declaração das Variáveis
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime Data_Nasc { get; set; }
        public bool Ativo { get; set; }
        public Cargo Id_Cargo { get; set; }


        // Métodos Construtores

        // Método Com Tudo
        public Funcionario(int id, string nome, string rg, string cpf, DateTime data_Nasc, bool ativo, Cargo id_Cargo)
        {
            Id = id;
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Ativo = ativo;
            Id_Cargo = id_Cargo;

        }

        // Método Sem Id
        public Funcionario(string nome, string rg, string cpf, DateTime data_Nasc, bool ativo, Cargo id_Cargo)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Ativo = ativo;
            Id_Cargo = id_Cargo;

        }

        // Método Sem Id e Ativo
        public Funcionario(string nome, string rg, string cpf, DateTime data_Nasc, Cargo id_Cargo)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Id_Cargo = id_Cargo;

        }

        // Método com Id e Ativo e Sem Id_Cargo
        public Funcionario(int id, string nome, string rg, string cpf, DateTime data_Nasc, bool ativo)
        {
            Id = id;
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Ativo = ativo;

        }

        // Método Vazio
        public Funcionario()
        {
            Id = new();
        }

        // Funções 

        // Função Inserir
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_funcionario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sprg", Rg);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nascimento", Data_Nasc);
            cmd.Parameters.AddWithValue("spid_cargo", Id_Cargo.Id); // Certifique-se de que Id_Cargo não é nulo
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            
        }

        // Função Atualizar
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_funcionario_update";
            cmd.Parameters.AddWithValue("sp_id", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sprg", Rg);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nascimento", Data_Nasc);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.Parameters.AddWithValue("spid_cargo", Id_Cargo.Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        // Função para deixar o funcionário inativo
        public void DeixarInativo(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update funcionarios set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        // Função para ativar o funcionário novamente
        public void DeixarAtivo(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update funcionarios set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static Funcionario ObterPorId(int Id)
        {
            Funcionario funcionario = new Funcionario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from funcionarios where id = {Id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5),
                    Cargo.ObterPorId(dr.GetInt32(6))
                    );
            }
            cmd.Connection.Close();
            return funcionario;
        }

        //Função Listar
        public static List<Funcionario> ObterPorLista(string? nome = "")
        {
            List<Funcionario> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "Select * from funcionarios order by nome";
            }
            else
            {
                cmd.CommandText = $"Select * from funcionarios where nome like '%{nome}%' order by nome";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5),
                    Cargo.ObterPorId(dr.GetInt32(6))
                    ));
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}