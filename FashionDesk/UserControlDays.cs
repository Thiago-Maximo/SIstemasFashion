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
    public partial class UserControlDays : UserControl
    {
        public DateTime Data { get; set; }
        public int Dia { get; set; }

        public UserControlDays(DateTime data)
        {
            InitializeComponent();
            this.Data = data;
            this.Dia = data.Day;
            lblDays.Text = this.Dia.ToString();
        }


        private void lblDays_Click(object sender, EventArgs e)
        {
            //Abrir Formulario para gravar Eventos
            FrmInserirAgendamentos frmInserirAgendamentos = new();
            frmInserirAgendamentos.ShowDialog();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            //Abrir Formulario para Gravar Eventos
            FrmInserirAgendamentos frmInserirAgendamentos = new();
            frmInserirAgendamentos.ShowDialog();
        }
    }
}
