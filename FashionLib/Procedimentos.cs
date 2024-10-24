using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FashionLib
{
    public class Procedimentos
    {
        // Declarando Váriaveis
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TimeOnly Duracacao_Estimada { get; set; }
        public char Classificacao { get; set; }

        // Métodos Construtores

        // Método com Tudo

        public Procedimentos(int id, string nome, string descricao, decimal valor, TimeOnly duracao_estimada, char classificacao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Duracacao_Estimada = duracao_estimada;
            Classificacao = classificacao;
        }
        // Método sem Id
        public Procedimentos(string nome, string descricao, decimal valor, TimeOnly duracao_estimada, char classificacao)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Duracacao_Estimada = duracao_estimada;
            Classificacao = classificacao;
        }

        // Método Vazio
        public Procedimentos()
        {
            Id = new();
        }

        // Funções

        // Função Inserir
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_procedimentos_insert";
            cmd.Parameters.AddWithValue("sp_nome", Nome);
            cmd.Parameters.AddWithValue("sp_descricao", Descricao);
            cmd.Parameters.AddWithValue("sp_valor", Valor);
            cmd.Parameters.AddWithValue("sp_duracao_estimada", Duracacao_Estimada);
            cmd.Parameters.AddWithValue("sp_classificacao", Classificacao);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        // Função Update
        public void Update()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_procedimentos_insert";
            cmd.Parameters.AddWithValue("sp_nome", Nome);
            cmd.Parameters.AddWithValue("sp_descricao", Descricao);
            cmd.Parameters.AddWithValue("sp_valor", Valor);
            cmd.Parameters.AddWithValue("sp_duracao_estimada", Duracacao_Estimada);
            cmd.Parameters.AddWithValue("sp_classificacao", Classificacao);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}


