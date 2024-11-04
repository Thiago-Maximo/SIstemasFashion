using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Data;
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
        public string Email { get; set; }

        // Métodos Construtores
        public Funcionario(int id, string nome, string rg, string cpf, DateTime data_Nasc, bool ativo, Cargo id_Cargo, string email)
        {
            Id = id;
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Ativo = ativo;
            Id_Cargo = id_Cargo;
            Email = email;
        }

        public Funcionario(string nome, string rg, string cpf, DateTime data_Nasc, Cargo id_Cargo, string email)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Id_Cargo = id_Cargo;
            Email = email;
        }

        public Funcionario() { }

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
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.Parameters.AddWithValue("spid_cargo", Id_Cargo.Id);
            cmd.Parameters.AddWithValue("sp_email", Email);

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0); // Atribui o ID retornado, se houver.
            }
            dr.Close();
            cmd.Connection.Close();
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
            cmd.Parameters.AddWithValue("sp_email", Email);

            
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        // Função para deixar o funcionário inativo
        public void DeixarInativo()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update funcionarios set ativo = 0 where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        // Função para ativar o funcionário novamente
        public void DeixarAtivo()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update funcionarios set ativo = 1 where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        // Obter Funcionário por ID
        public static Funcionario ObterPorId(int id)
        {
            Funcionario funcionario = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from funcionarios where id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                funcionario = new Funcionario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5),
                    Cargo.ObterPorId(dr.GetInt32(6)),
                    dr.GetString(7)
                );
            }
            dr.Close();
            cmd.Connection.Close();
            return funcionario;
        }

        // Listar Funcionários por Nome
        public static List<Funcionario> ObterPorLista(string nome = "")
        {
            List<Funcionario> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.IsNullOrEmpty(nome) ?
                "Select * from funcionarios order by nome" :
                "Select * from funcionarios where nome like @nome order by nome";

            if (!string.IsNullOrEmpty(nome))
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Funcionario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5),
                    Cargo.ObterPorId(dr.GetInt32(6)),
                    dr.GetString(7)
                ));
            }
            dr.Close();
            cmd.Connection.Close();
            return lista;
        }
    }
}
