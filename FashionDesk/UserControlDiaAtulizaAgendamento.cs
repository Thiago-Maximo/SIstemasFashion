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
    public partial class UserControlDiaAtulizaAgendamento : UserControl
    {
        public DateTime Data { get; set; }
        public int Dia { get; set; }

        public string DiaSelecionado { get; set; }

        public Guna.UI2.WinForms.Guna2HtmlLabel lblDiasAtualizados
        {
            get { return lblDays; }
        }

        public UserControlDiaAtulizaAgendamento(DateTime data)
        {
            InitializeComponent();
            this.Data = data;
            this.Dia = data.Day;
            lblDays.Text = this.Dia.ToString();

        }

        private void lblDays_Click(object sender, EventArgs e)
        {
            // Passa a data completa para a variável estática dataNova no FrmAtualizarAgendamento
            FrmAtualizarAgendamento.dataNova = this.Data.ToString("dd/MM/yyyy");

            // Fecha o formulário atual (onde está o UserControl)
            FrmAtualizaDiaAgendado parentForm = this.FindForm() as FrmAtualizaDiaAgendado; // Conversão explícita para FrmAtualizaDiaAgendado

            // Verifique se a conversão foi bem-sucedida
            if (parentForm != null)
            {
                parentForm.Close();
            }

            // Recarrega o formulário FrmAtualizarAgendamento com a nova data
            FrmAtualizarAgendamento frmAtualizarAgendamento = new FrmAtualizarAgendamento();
            frmAtualizarAgendamento.Show();
        }

        private void UserControlDiaAtulizaAgendamento_Click(object sender, EventArgs e)
        {
            // Passa a data completa para a variável estática dataNova no FrmAtualizarAgendamento
            FrmAtualizarAgendamento.dataNova = this.Data.ToString("dd/MM/yyyy");

            // Fecha o formulário atual (onde está o UserControl)
            FrmAtualizaDiaAgendado parentForm = this.FindForm() as FrmAtualizaDiaAgendado; // Conversão explícita para FrmAtualizaDiaAgendado

            // Verifique se a conversão foi bem-sucedida
            if (parentForm != null)
            {
                parentForm.Close();
            }

            // Recarrega o formulário FrmAtualizarAgendamento com a nova data
            FrmAtualizarAgendamento frmAtualizarAgendamento = new FrmAtualizarAgendamento();
            frmAtualizarAgendamento.Show();
        }
    }
}
