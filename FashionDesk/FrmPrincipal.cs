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
        public FrmPrincipal()
        {
            InitializeComponent();
            panelFuncionarios.Height = 0;
            panelClientes.Height = 0;
            panelAgendamentos.Height = 0;
            panelAdmin.Height = 0;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            ShowFuncionarios = !ShowFuncionarios;
            ExibirDropDown();
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
                panelFuncionarios.Height = 141;
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
                panelClientes.Height = 154;
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
                panelAgendamentos.Height = 148;
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
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ShowClientes = !ShowClientes;
            ExibirDropDown();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            ShowAgendamentos = !ShowAgendamentos;
            ExibirDropDown();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowAdmin = !ShowAdmin;
            ExibirDropDown();
        }
    }
}
