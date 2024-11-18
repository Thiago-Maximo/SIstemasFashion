using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FashionLib
{
    public class FuncionarioEndereco
    {
        // Declaração das Variáveis
        public int Id { get; set; }
        public Funcionario Id_funcionario { get; set; }
        public Endereco Id_Endereco { get; set; }


        // Métodos Construtores
        public FuncionarioEndereco(int id, Funcionario id_funcionario, Endereco id_endereco)
        {
            Id = id;
            Id_funcionario = id_funcionario;
            Id_Endereco = id_endereco;
        }

        // Sem Id
        public FuncionarioEndereco( Funcionario id_funcionario, Endereco id_endereco)
        {
            
            Id_funcionario = id_funcionario;
            Id_Endereco = id_endereco;
        }

        // Sem nada
        public FuncionarioEndereco() { }
        
     


        // Função Inserir

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_funcionarios_enderecos_insert";

            cmd.Parameters.AddWithValue("sp_id_funcionario", Id_funcionario.Id);
            cmd.Parameters.AddWithValue("sp_id_endereco", Id_Endereco.Id);

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
            cmd.CommandText = "sp_funcionarios_enderecos_update";

            cmd.Parameters.AddWithValue("sp_id", Id);
            cmd.Parameters.AddWithValue("sp_id_funcionario", Id_funcionario.Id);
            cmd.Parameters.AddWithValue("sp_id_endereco", Id_Endereco.Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static FuncionarioEndereco ObterPorId(int id)
        {
            FuncionarioEndereco funcionarioEndereco = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from funcionarios_enderecos where id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                funcionarioEndereco = new FuncionarioEndereco(
                    dr.GetInt32(0),
                    Funcionario.ObterPorId(dr.GetInt32(1)),
                    Endereco.ObterPorId(dr.GetInt32(2))
                );
            }
            dr.Close();
            cmd.Connection.Close();
            return funcionarioEndereco;
        }
        public static List<FuncionarioEndereco> ObterPorLista(string? nome = "")
        {
            List<FuncionarioEndereco> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "Select * from funcionarios_enderecos order by Id";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        Funcionario.ObterPorId(dr.GetInt32(1)),
                        Endereco.ObterPorId(dr.GetInt32(2))
                        )


                    );
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}
