using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Data;

namespace FashionLib
{
    public class Agendamentos
    {
        public int Id { get; set; }
        public Cliente Id_Cliente { get; set; }
        public Funcionario Id_Funcionario { get; set; }
        public DateTime Data_Agendamento { get; set; }
        public DateTime Hora_Agendamento { get; set; }
        public Procedimentos Id_procedimentos { get; set; }

        public Agendamentos(int id, Cliente id_Cliente, Funcionario id_Funcionario, DateTime data_Agendamento, DateTime hora_Agendamento, Procedimentos id_procedimentos)
        {
            Id = id;
            Id_Cliente = id_Cliente;
            Id_Funcionario = id_Funcionario;
            Data_Agendamento = data_Agendamento;
            Hora_Agendamento = hora_Agendamento;
            Id_procedimentos = id_procedimentos;
        }

        public Agendamentos(Cliente id_Cliente, Funcionario id_Funcionario, DateTime data_Agendamento, DateTime hora_Agendamento, Procedimentos id_procedimentos)
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
            var cmd = Banco.Abrir(); // Assume-se que Banco.Abrir() retorna uma conexão aberta
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT hora FROM agendamentos WHERE data_agendamento = @data";
            cmd.Parameters.AddWithValue("@data", data.Date);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Usar GetTimeSpan se a coluna 'hora' for do tipo TIME no banco de dados
                TimeSpan hora = dr.GetTimeSpan(dr.GetOrdinal("hora"));

                // Adicionar o formato "hh:mm" para exibição
                horasAgendadas.Add(hora.ToString(@"hh\:mm"));
            }
            cmd.Connection.Close();
            return horasAgendadas;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_agendamento_insert";
            cmd.Parameters.AddWithValue("spid_cliente", Id_Cliente.Id);
            cmd.Parameters.AddWithValue("spid_funcionario", Id_Funcionario.Id);
            cmd.Parameters.AddWithValue("spdia", Data_Agendamento);
            cmd.Parameters.AddWithValue("sphora", Hora_Agendamento);
            cmd.Parameters.AddWithValue("spid_procedimentos", Id_procedimentos.Id);

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
                    Cliente.ObterPorId(dr.GetInt32(1)),
                    Funcionario.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    Procedimentos.ObterPorId(dr.GetInt32(5))
                );
            }
            cmd.Connection.Close();
            return agendamento;
        }

        public static List<string> ObterHorasAgendadasPorDataFuncionario(DateTime data, int funcionarioId)
        {
            List<string> horasAgendadas = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT hora FROM agendamentos WHERE data_agendamento = @data AND id_funcionario = @funcionarioId";
            cmd.Parameters.AddWithValue("@data", data.Date);
            cmd.Parameters.AddWithValue("@funcionarioId", funcionarioId);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                horasAgendadas.Add(((TimeSpan)dr["hora"]).ToString(@"hh\:mm"));
            }
            cmd.Connection.Close();
            return horasAgendadas;
        }

        public static List<Agendamentos> ObterPorLista(string? nome = "")
        {
            List<Agendamentos> lista = new();
            var cmd = Banco.Abrir();  // Assume-se que Banco.Abrir() retorna uma conexão aberta
            cmd.CommandType = CommandType.Text;

            // Verifique se o nome foi informado e construa a consulta adequadamente
            if (string.IsNullOrEmpty(nome))
            {
                // Se nome estiver vazio ou nulo, use uma consulta simples
                cmd.CommandText = "SELECT * FROM agendamentos";
            }
            else
            {
                // Se nome não estiver vazio, adicione uma condição à consulta
                cmd.CommandText = "SELECT * FROM agendamentos WHERE data_agendamento LIKE @nome";
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");  // Parâmetro para evitar SQL Injection
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Ler as colunas corretamente
                DateTime dataAgendamento = dr.GetDateTime(3); // Assumindo que o campo 'data_agendamento' é DateTime
                TimeSpan horaAgendamento = dr.GetTimeSpan(4); // Assumindo que o campo 'hora_agendamento' é do tipo TIME (TimeSpan)

                // Combinar a data com a hora para obter um DateTime completo
                DateTime dataHoraAgendamento = dataAgendamento.Date + horaAgendamento;

                lista.Add(new Agendamentos(
                    dr.GetInt32(0),
                    Cliente.ObterPorId(dr.GetInt32(1)),
                    Funcionario.ObterPorId(dr.GetInt32(2)),
                    dataAgendamento,
                    dataHoraAgendamento,  // Aqui passa-se o DateTime combinado, não mais TimeSpan
                    Procedimentos.ObterPorId(dr.GetInt32(5))
                ));
            }
            cmd.Connection.Close();
            return lista;
        }


    }
}