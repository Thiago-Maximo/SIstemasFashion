using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FashionLib
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Data_Nasc { get; set; }
        public bool Ativo { get; set; }
        public string Email { get; set; }

        //Método Construtor Vazio
        public Cliente()
        {
            Id = new();
        }

        //Método Construtor com Tudo
        public Cliente(int id, string nome, string cpf, DateTime data_Nasc, bool ativo,string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Ativo = ativo;
            Email = email;
        }

       


        //Método Construtor Sem Id
        public Cliente(string nome, string cpf, DateTime data_Nasc, bool ativo)
        {

            Nome = nome;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Ativo = ativo;
        }

        //Método Construtor sem Id e Ativo
        public Cliente(string nome, string cpf, DateTime data_Nasc,string email)
        {

            Nome = nome;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Email = email;
        }

        public Cliente(string nome, string cpf, DateTime data_Nasc,bool ativo, string email)
        {

            Nome = nome;
            Cpf = cpf;
            Data_Nasc = data_Nasc;
            Ativo = ativo;
            Email = email;
        }

        //Método Construtor sem Data_Nasc
        public Cliente(int id, string nome, string cpf, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Ativo = ativo;
        }

        //Função para Inserir Cliente
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nascimento", Data_Nasc);
            cmd.Parameters.AddWithValue("sp_email", Email);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        //Função para Atulizar todos os Dados do Cliente
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("sp_id", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nascimento", Data_Nasc);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        // Função para deixar o funcionário inativo
        public void DeixarInativo(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        // Função para ativar o funcionário novamente
        public void DeixarAtivo(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDateTime(3),
                        dr.GetBoolean(4),
                        dr.GetString(5)
                    );
            }
            cmd.Connection.Close();
            return cliente;
        }
        public static List<Cliente> ObterPorLista(string? nome = "")
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "Select * from clientes order by nome";
            }
            else
            {
                cmd.CommandText = $"Select * from clientes where nome like '%{nome}%' order by nome";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDateTime(3),
                        dr.GetBoolean(4),
                        dr.GetString(5)
                        )
                    );
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}
