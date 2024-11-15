﻿using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FashionLib
{
    public class FuncionarioProcedimento
    {
        // Declaração das Variáveis
        public int Id { get; set; }
        public Funcionario Id_funcionario { get; set; }
        public Procedimentos Id_Procedimentos { get; set; }


        // Métodos Construtores
        public FuncionarioProcedimento(int id, Funcionario id_funcionario, Procedimentos id_procedimentos)
        {
            Id = id;
            Id_funcionario = id_funcionario;
            Id_Procedimentos = id_procedimentos;
        }

        // Sem Id
        public FuncionarioProcedimento(Funcionario id_funcionario, Procedimentos id_procedimentos)
        {
            Id_funcionario = id_funcionario;
            Id_Procedimentos = id_procedimentos;
        }
        public FuncionarioProcedimento(int id)
        {
            Id = id;
        }

        // Sem Nada
        public FuncionarioProcedimento() { }

        // Função Inserir

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_funcionarios_procedimentos_insert";

            cmd.Parameters.AddWithValue("spid_funcionario", Id_funcionario.Id);
            cmd.Parameters.AddWithValue("spid_procedimento", Id_Procedimentos.Id);

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            dr.Close();
            cmd.Connection.Close();
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_funcionarios_procedimentos_update";

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spid_funcionario", Id_funcionario.Id);
            cmd.Parameters.AddWithValue("spid_procedimento", Id_Procedimentos.Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static FuncionarioProcedimento ObterPorId(int id)
        {
            FuncionarioProcedimento funcionarioProcedimento = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from funcionarios_procedimentos where id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                funcionarioProcedimento = new FuncionarioProcedimento(
                    dr.GetInt32(0),
                    Funcionario.ObterPorId(dr.GetInt32(1)),
                    Procedimentos.ObterPorId(dr.GetInt32(2))
                );
            }
            dr.Close();
            cmd.Connection.Close();
            return funcionarioProcedimento;
        }
        public static List<FuncionarioProcedimento> ObterPorLista(string? nome = "")
        {
            List<FuncionarioProcedimento> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "Select * from funcionarios_procedimentos order by Id";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        Funcionario.ObterPorId(dr.GetInt32(1)),
                        Procedimentos.ObterPorId(dr.GetInt32(2))
                        )

                  
                    );
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}
