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
    public partial class FrmPrincipal : Form
    {
        private Boolean ShowFuncionarios = false;
        private Boolean ShowClientes = false;
        private Boolean ShowAgendamentos = false;
        private Boolean ShowAdmin = false;
        private bool ShowUser = false;
        public FrmPrincipal()
        {
            InitializeComponent();
            panelFuncionarios.Height = 0;
            panelClientes.Height = 0;
            panelAgendamentos.Height = 0;
            panelAdmin.Height = 0;
            panelUser.Height = 0;
        }

        //#######                             ######                       ######                       
        //#       #    # # #####  # #####     #     # #####   ####  #####  #     #  ####  #    # #    # 
        //#        #  #  # #    # # #    #    #     # #    # #    # #    # #     # #    # #    # ##   # 
        //#####     ##   # #####  # #    #    #     # #    # #    # #    # #     # #    # #    # # #  # 
        //#         ##   # #    # # #####     #     # #####  #    # #####  #     # #    # # ## # #  # # 
        //#        #  #  # #    # # #   #     #     # #   #  #    # #      #     # #    # ##  ## #   ## 
        //####### #    # # #####  # #    #    ######  #    #  ####  #      ######   ####  #    # #    # 



        private void ExibirDropDown()//Exibe os botões que estão dentro dos panels
        {
            //#######                                                             
            //#       #    # #    #  ####  #  ####  #    #   ##   #####  #  ####  
            //#       #    # ##   # #    # # #    # ##   #  #  #  #    # # #    # 
            //#####   #    # # #  # #      # #    # # #  # #    # #    # # #    # 
            //#       #    # #  # # #      # #    # #  # # ###### #####  # #    # 
            //#       #    # #   ## #    # # #    # #   ## #    # #   #  # #    # 
            //#        ####  #    #  ####  #  ####  #    # #    # #    # #  ####  
            if (ShowFuncionarios)
            {
                panelFuncionarios.Height = 135;
            }
            else
            {
                panelFuncionarios.Height = 0;
            }

            //#####                                      
            //#     # #      # ###### #    # ##### ###### 
            //#       #      # #      ##   #   #   #      
            //#       #      # #####  # #  #   #   #####  
            //#       #      # #      #  # #   #   #      
            //#     # #      # #      #   ##   #   #      
            //#####  ###### # ###### #    #   #   ###### 
            if (ShowClientes)
            {
                panelClientes.Height = 135;
            }
            else
            {
                panelClientes.Height = 0;
            }

            //#                                                                                
            //# #    ####  ###### #    # #####    ##   #    # ###### #    # #####  ####   ####  
            //#   #  #    # #      ##   # #    #  #  #  ##  ## #      ##   #   #   #    # #      
            //#     # #      #####  # #  # #    # #    # # ## # #####  # #  #   #   #    #  ####  
            //####### #  ### #      #  # # #    # ###### #    # #      #  # #   #   #    #      # 
            //#     # #    # #      #   ## #    # #    # #    # #      #   ##   #   #    # #    # 
            //#     #  ####  ###### #    # #####  #    # #    # ###### #    #   #    ####   ####  
            if (ShowAgendamentos)
            {
                panelAgendamentos.Height = 135;
            }
            else
            {
                panelAgendamentos.Height = 0;
            }

            //#                           
            //# #   #####  #    # # #    # 
            //#   #  #    # ##  ## # ##   # 
            //#     # #    # # ## # # # #  # 
            //####### #    # #    # # #  # # 
            //#     # #    # #    # # #   ## 
            //#     # #####  #    # # #    # 
            if (ShowAdmin)
            {
                panelAdmin.Height = 158;
            }
            else
            {
                panelAdmin.Height = 0;
            }

            //#     #                      
            //#     #  ####  ###### #####  
            //#     # #      #      #    # 
            //#     #  ####  #####  #    # 
            //#     #      # #      #####  
            //#     # #    # #      #   #  
            //#####   ####  ###### #    # 
            if (ShowUser)
            {
                panelUser.Height = 69;
            }
            else
            {
                panelUser.Height = 0;
            }
        }




        // FUNCIONARIO

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            ShowClientes = false;
            ShowAgendamentos = false;
            ShowAdmin = false;

            ShowFuncionarios = !ShowFuncionarios;
            ExibirDropDown();
        }

        private void btnInserirFuncionario_Click(object sender, EventArgs e)
        {
            FrmInserirFuncionario frmInserirFuncionario = new();
            frmInserirFuncionario.MdiParent = this;
            frmInserirFuncionario.Show();
        }

        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            FrmAtualizarFuncionario frmAtualizarFuncionario = new();
            frmAtualizarFuncionario.MdiParent = this;
            frmAtualizarFuncionario.Show();
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            FrmConsultarFuncionario frmConsultarFuncionario = new();
            frmConsultarFuncionario.MdiParent = this;
            frmConsultarFuncionario.Show();
        }

        // CLIENTE
        private void btnClientes_Click(object sender, EventArgs e)
        {
            ShowAgendamentos = false;
            ShowFuncionarios = false;
            ShowAdmin = false;

            ShowClientes = !ShowClientes;
            ExibirDropDown();
        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            FrmInserirCliente frmInserirCliente = new();
            frmInserirCliente.MdiParent = this;
            frmInserirCliente.Show();
        }


        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            FrmAtualizarCliente frmAtualizarCliente = new();
            frmAtualizarCliente.MdiParent = this;
            frmAtualizarCliente.Show();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmConsultaClientes = new();
            frmConsultaClientes.MdiParent = this;
            frmConsultaClientes.Show();
        }

        // AGENDAMENTO

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            ShowClientes = false;
            ShowFuncionarios = false;
            ShowAdmin = false;

            ShowAgendamentos = !ShowAgendamentos;
            ExibirDropDown();
        }

        private void btnInserirAgendamentos_Click(object sender, EventArgs e)
        {
            FrmAgendamentos frmAgendamentos = new();
            frmAgendamentos.MdiParent = this;
            frmAgendamentos.Show();
        }

        // ADMIN

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowClientes = false;
            ShowFuncionarios = false;
            ShowAgendamentos = false;

            ShowAdmin = !ShowAdmin;
            ExibirDropDown();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowUser = !ShowUser;
            ExibirDropDown();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new();
            frmPrincipal.Close();
        }

        private void btnConsultarAgendamentos_Click(object sender, EventArgs e)
        {
            FrmConsultaAgendamento frmAgendamentos = new();
            frmAgendamentos.MdiParent = this;
            frmAgendamentos.Show();
        }

        private void btnProcedimentos_Click(object sender, EventArgs e)
        {
            FrmProcedimentos frmProcedimentos = new();
            frmProcedimentos.MdiParent = this;
            frmProcedimentos.Show();
        }
    }
}
