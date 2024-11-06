using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace FashionLib
{
    public class Agendamentos
    {//Declaração das Variaveis
       

        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Funcionario { get; set; }
        public DateTime Data_Agendamento { get; set; }
        public DateTime Hora_Agendamento { get; set; }
        public int Id_procedimentos { get; set; }

        //Métodos Construtores

        public Agendamentos(int id, int id_Cliente, int id_Funcionario, DateTime data_Agendamento, DateTime hora_Agendamento, int id_procedimentos)
        {
            Id = id;
            Id_Cliente = id_Cliente;
            Id_Funcionario = id_Funcionario;
            Data_Agendamento = data_Agendamento;
            Hora_Agendamento = hora_Agendamento;
            Id_procedimentos = id_procedimentos;
        }

        public Agendamentos( int id_Cliente, int id_Funcionario, DateTime data_Agendamento, DateTime hora_Agendamento, int id_procedimentos)
        {
           
            Id_Cliente = id_Cliente;
            Id_Funcionario = id_Funcionario;
            Data_Agendamento = data_Agendamento;
            Hora_Agendamento = hora_Agendamento;
            Id_procedimentos = id_procedimentos;
        }

        public Agendamentos()
        {
            
        }

        //Funções

        //Função Para Inserir
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"sp_agendamento_insert";
            cmd.Parameters.AddWithValue("spid_cliente",Id_Cliente);
            cmd.Parameters.AddWithValue("spid_funcionario", Id_Funcionario);
            cmd.Parameters.AddWithValue("spdia",Data_Agendamento);
            cmd.Parameters.AddWithValue("sphora", Hora_Agendamento);
            cmd.Parameters.AddWithValue("spid_procedimentos", Id_procedimentos);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        //Função para Atualizar
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "sp_agendamento_update";
            cmd.Parameters.AddWithValue("spid_cliente", Id_Cliente);
            cmd.Parameters.AddWithValue("spid_funcionario", Id_Funcionario);
            cmd.Parameters.AddWithValue("spdia", Data_Agendamento);
            cmd.Parameters.AddWithValue("sphora", Hora_Agendamento);
            cmd.Parameters.AddWithValue("spid_procedimentos", Id_procedimentos);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        //Função Listar
        public static List<Agendamentos> ObterPorLista(string? nome = "")
        {
            List<Agendamentos> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "Select * from agendamentos";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                dr.GetInt32(0),
                dr.GetInt32(1),
                dr.GetDateTime(2),
                dr.GetDateTime(3),
                dr.GetInt32(4)
                    ));
            }
            cmd.Connection.Close();
            return lista;
        }

        //Função Onter Por Id
        public static Agendamentos ObterPorId(int Id)
        {
            Agendamentos agendamentos = new Agendamentos();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from agendamentos where id = {Id}";
            cmd.Connection.Close();
            return agendamentos;
        }

        public void ConsultaHora()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT FROM agendamentos WHERE hora = {Hora_Agendamento}";
            cmd.Connection.Close();
            
        }


    }
}
