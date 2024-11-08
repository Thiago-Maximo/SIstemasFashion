using SysPecNSLib;
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
        // Declaração cas Variáveis
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

        // Sem Nada
        public FuncionarioProcedimento() { }

        // Função Inserir

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_funcionarios_procedimentos_insert";

            cmd.Parameters.AddWithValue("spid_funcionario", Id_funcionario);
            cmd.Parameters.AddWithValue("spid_procedimentos", Id_Procedimentos);

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            dr.Close();
            cmd.Connection.Close();
        }
    }
}
