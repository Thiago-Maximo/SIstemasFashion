using FashionLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja continuar o Login ?",
                    "Confirmação de saída",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.No) this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TxtLogin.Text != string.Empty && TxtSenha.Text != string.Empty)
            {
                // Realiza a tentativa de login
                var usuario = Usuario.EfetuarLogin(TxtLogin.Text, TxtSenha.Text);

                // Verifica se o usuário foi encontrado
                if (usuario.IdUsuarios > 0)
                {
                    // Verificação de nível e status ativo
                    if (usuario.Ativo)
                    {
                        if (usuario.Nivel == "Gerente" || usuario.Nivel == "Administrador" || usuario.Nivel == "Recepcionista") // Verificando se o Nivel do Usuario é permitido para realizar Login No Sistema
                        {
                            Program.UsuarioLogado = usuario;

                            // Oculta o formulário de login
                            this.Hide();

                            // Inicializa o formulário principal
                            FrmPrincipal frmPrincipal = new FrmPrincipal();
                            frmPrincipal.FormClosed += (s, args) => this.Close(); // Fecha o login quando o principal é fechado
                            frmPrincipal.Show();
                        }
                        else
                        {
                            MessageBox.Show("Seu usuário não tem permissão de acesso. \n Contate a gerência.",
                                "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seu usuário está inativo. \n Contate a gerência.",
                            "Usuário Inativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos. \n Tente novamente.",
                        "Login Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você deve preencher todos os campos.",
                    "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLogin.Focus();
            }
        }
    }
}

