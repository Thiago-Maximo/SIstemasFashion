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
    public partial class FrmAtualizaDiaAgendado : Form
    {
        public DateTime dataAtual;
        public FrmAtualizaDiaAgendado()
        {
            InitializeComponent();

            dataAtual = DateTime.Now;
            DisplayDays();
        }
        private void DisplayDays()
        {
            lblTitulo.Text = dataAtual.ToString("MMMM yyyy");
            daycontainer.Controls.Clear();
            int diasDoMes = DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            int diaDaSemana = (int)new DateTime(dataAtual.Year, dataAtual.Month, 1).DayOfWeek;
            int x = 0;
            int y = 0;
            for (int i = 0; i < diaDaSemana; i++)
            {
                UserControlBlankDiaAtualizado ucblank = new UserControlBlankDiaAtualizado();
                ucblank.Width = 108;
                ucblank.Height = 59;
                ucblank.Location = new Point(x, y);
                daycontainer.Controls.Add(ucblank);
                x += 130;
            }
            x = 0;
            y = 80;
            for (int i = 1; i <= diasDoMes; i++)
            {
                DateTime data = new DateTime(dataAtual.Year, dataAtual.Month, i);
                UserControlDiaAtulizaAgendamento ucdays = new UserControlDiaAtulizaAgendamento(data);
                ucdays.Dia = i;
                ucdays.Data = data;
                ucdays.Width = 108;
                ucdays.Height = 59;
                ucdays.Location = new Point(x, y);
                daycontainer.Controls.Add(ucdays);
                x += 130;
                if (x > 800)
                {
                    x = 0;
                    y += 90;
                }
            }
        }

        private void lblAvancar_Click(object sender, EventArgs e)
        {
            dataAtual = dataAtual.AddMonths(1);
            DisplayDays();
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            dataAtual = dataAtual.AddMonths(-1);
            DisplayDays();
        }

        private void btnfecharForm_Click(object sender, EventArgs e)
        {

            FrmAtualizaDiaAgendado frmAgendamentos = new();
            frmAgendamentos.Close();
        }
    }
}
