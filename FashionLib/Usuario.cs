using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLib
{
    public class Usuario
    {
        
        public int IdUsuarios { get; set; }
        public string Email { get; set; }
        public string Nivel { get; set; }
        public string Senha { get; set; }

        public Usuario(int idusuarios,string email, string nivel, string senha)
        {
            IdUsuarios = idusuarios;
            Email = email;
            Nivel = nivel;
            Senha = senha;
        }

        public Usuario(string email, string nivel, string senha)
        {
            Email = email;
            Nivel = nivel;
            Senha = senha;
        }

        public Usuario()
        {
          
        }

        public static Usuario EfetuarLogin(string Email, string Senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where email = '{Email}' and senha = '{Senha}'";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3)
                    );
            }
            return usuario;
        }

        public static void Arquivar(int id)
        {
            // Deixar o ativo do usuario para falso = Inativo no sistema
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update usuarios set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Restaurar(int id)
        {
            // Deixar o ativo do usuario para verdadeiro = Ativo no sistema
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update usuarios set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        ///faltando fazer o o atualizar e inserir
    }
}
