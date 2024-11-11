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
    public partial class FrmSelecionarAgendamento : Form
    {
        public string AgendamentoSelecionado { get; private set; }
        public int IdAgendamentoSelecionado { get; set; }
        public string FuncionarioSelecionado { get; set; }
        public int Id_Funcionario { get; set; }
        public FrmSelecionarAgendamento()
        {
            InitializeComponent();
        }

        private void FrmSelecionarAgendamento_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void CarregaGrid(string nome = "")
        {
            var lista = Agendamentos.ObterPorLista(nome);
            dgvConsultaAgendamento.Rows.Clear();
            int cont = 0;
            foreach (var agendamentos in lista)
            {
                dgvConsultaAgendamento.Rows.Add();
                dgvConsultaAgendamento.Rows[cont].Cells[0].Value = agendamentos.Id;
                dgvConsultaAgendamento.Rows[cont].Cells[4].Value = agendamentos.Id_Cliente.Nome;
                dgvConsultaAgendamento.Rows[cont].Cells[6].Value = agendamentos.Id_Funcionario.Nome;

                // Formatar a data para exibir apenas a data
                dgvConsultaAgendamento.Rows[cont].Cells[1].Value = agendamentos.Data_Agendamento.ToString("dd/MM/yyyy"); // Ou outro formato desejado
                dgvConsultaAgendamento.Rows[cont].Cells[2].Value = agendamentos.Hora_Agendamento.ToString(@"hh\:mm\:ss");

                dgvConsultaAgendamento.Rows[cont].Cells[7].Value = agendamentos.Id_procedimentos.Nome;
                dgvConsultaAgendamento.Rows[cont].Cells[8].Value = agendamentos.Status;

                dgvConsultaAgendamento.Rows[cont].Cells[3].Value = agendamentos.Id_Cliente.Id;
                dgvConsultaAgendamento.Rows[cont].Cells[5].Value = agendamentos.Id_Funcionario.Id;
                cont++;
            }
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            if (txtConsultar.Text.Length > 0)
            {
                CarregaGrid(txtConsultar.Text);
            }
            else
            {
                CarregaGrid();
            }
        }

        private void dgvConsultaAgendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pegue o nome do cliente da linha selecionada
                AgendamentoSelecionado = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdAgendamentoSelecionado = Convert.ToInt32(dgvConsultaAgendamento.Rows[e.RowIndex].Cells[0].Value.ToString());
                FuncionarioSelecionado = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[6].Value.ToString();
                Id_Funcionario = Convert.ToInt32(dgvConsultaAgendamento.Rows[e.RowIndex].Cells[5].Value.ToString());
                // Fecha o formulário após selecionar o cliente
                this.Close();
            }
        }
    }
}
