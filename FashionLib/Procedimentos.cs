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

        public Procedimentos(int id, string nome)
        {
            Id = id;
            Nome = nome;
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

        public static List<Procedimentos> ObterPorLista(string? procedimentos = "")
        {
            List<Procedimentos> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (procedimentos == "")
            {
                cmd.CommandText = "select * from procedimentos order by nome";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),          // Id
                    dr.GetString(1),         // Nome
                    dr.GetString(2),         // Descrição
                    dr.GetDecimal(3),        // Valor
                    TimeOnly.FromTimeSpan(dr.GetTimeSpan(4)), // Duracao Estimada
                    dr.GetChar(5)            // Classificação
                    ));
            }
            cmd.Connection.Close();
            return lista;
        }

        public static Procedimentos ObterPorId(int id)
        {
            Procedimentos procedimento = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id, nome, descricao, valor, duracao_estimada, classificacao " +
                              "FROM procedimentos WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                procedimento = new Procedimentos(
                    dr.GetInt32(0),          // Id
                    dr.GetString(1),         // Nome
                    dr.GetString(2),         // Descrição
                    dr.GetDecimal(3),        // Valor
                    TimeOnly.FromTimeSpan(dr.GetTimeSpan(4)), // Duracao Estimada
                    dr.GetChar(5)            // Classificação
                );

            }
            cmd.Connection.Close();
            return procedimento;
        }
    }
}


