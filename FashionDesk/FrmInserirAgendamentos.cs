using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FashionDesk
{
    public partial class FrmInserirAgendamentos : Form
    {
        public FrmInserirAgendamentos(DateTime data)
        {
            InitializeComponent();
            txtDate.Text = data.ToString("yyyy-MM-dd");
            CarregarHoras();
        }

        private void CarregarHoras()
        {
            cmbHora.Items.Clear();
            for (int hora = 9; hora <= 17; hora++)
            {
                //if (Agr.dip(hora))// Criar um método que verifica se tem disponibilidade, comando mysql
                //{

                // }//
                string horaFormatada = hora.ToString("D2") + ":00";
                cmbHora.Items.Add(horaFormatada);
            }
            //AtualizarHorasDisponiveis();
        }


    }
}
