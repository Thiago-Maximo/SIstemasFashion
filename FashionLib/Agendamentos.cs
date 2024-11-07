using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Data;

namespace FashionLib
{
    public class Agendamentos
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Funcionario { get; set; }
        public DateTime Data_Agendamento { get; set; }
        public DateTime Hora_Agendamento { get; set; }
        public int Id_procedimentos { get; set; }

        public Agendamentos(int id, int id_Cliente, int id_Funcionario, DateTime data_Agendamento, DateTime hora_Agendamento, int id_procedimentos)
        {
            Id = id;
            Id_Cliente = id_Cliente;
            Id_Funcionario = id_Funcionario;
            Data_Agendamento = data_Agendamento;
            Hora_Agendamento = hora_Agendamento;
            Id_procedimentos = id_procedimentos;
        }

        public Agendamentos(int id_Cliente, int id_Funcionario, DateTime data_Agendamento, DateTime hora_Agendamento, int id_procedimentos)
        {
            Id_Cliente = id_Cliente;
            Id_Funcionario = id_Funcionario;
            Data_Agendamento = data_Agendamento;
            Hora_Agendamento = hora_Agendamento;
            Id_procedimentos = id_procedimentos;
        }

        public Agendamentos() { }

        // Função para obter lista de horários agendados em uma data específica
        public static List<string> ObterHorasAgendadasPorData(DateTime data)
        {
            List<string> horasAgendadas = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT hora FROM agendamentos WHERE data_agendamento = @data";
            cmd.Parameters.AddWithValue("@data", data.Date);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Converta explicitamente o TimeSpan para string
                horasAgendadas.Add(((TimeSpan)dr["hora"]).ToString(@"hh\:mm"));
            }
            cmd.Connection.Close();
            return horasAgendadas;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_agendamento_insert";
            cmd.Parameters.AddWithValue("spid_cliente", Id_Cliente);
            cmd.Parameters.AddWithValue("spid_funcionario", Id_Funcionario);
            cmd.Parameters.AddWithValue("spdia", Data_Agendamento);
            cmd.Parameters.AddWithValue("sphora", Hora_Agendamento);
            cmd.Parameters.AddWithValue("spid_procedimentos", Id_procedimentos);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_agendamento_update";
            cmd.Parameters.AddWithValue("spid_cliente", Id_Cliente);
            cmd.Parameters.AddWithValue("spid_funcionario", Id_Funcionario);
            cmd.Parameters.AddWithValue("spdia", Data_Agendamento);
            cmd.Parameters.AddWithValue("sphora", Hora_Agendamento);
            cmd.Parameters.AddWithValue("spid_procedimentos", Id_procedimentos);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static List<Agendamentos> ObterPorLista(string? nome = "")
        {
            List<Agendamentos> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "SELECT * FROM agendamentos";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetInt32(2),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetInt32(5)
                ));
            }
            cmd.Connection.Close();
            return lista;
        }

        public static Agendamentos ObterPorId(int Id)
        {
            Agendamentos agendamento = new Agendamentos();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM agendamentos WHERE id = {Id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                agendamento = new Agendamentos(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetInt32(2),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetInt32(5)
                );
            }
            cmd.Connection.Close();
            return agendamento;
        }
    }
}