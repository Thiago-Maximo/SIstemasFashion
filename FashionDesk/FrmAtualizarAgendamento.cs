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
    public partial class FrmAtualizarAgendamento : Form
    {
        public Guna.UI2.WinForms.Guna2TextBox TxtClientes
        {
            get { return textClientes; }
        }

        public Guna.UI2.WinForms.Guna2TextBox TxtIdClientes
        {
            get { return txtIdClientes; }
        }

        public Guna.UI2.WinForms.Guna2TextBox TxtFuncionarios
        {
            get { return TextFuncionarios; }
        }

        public Guna.UI2.WinForms.Guna2TextBox TxtIdFuncionarios
        {
            get { return txtIdFuncionarios; }
        }

        public Guna.UI2.WinForms.Guna2TextBox TxtData
        {
            get { return txtDate; }
        }

        public Guna.UI2.WinForms.Guna2ComboBox CMBHora
        {
            get { return cmbHora; }
        }

        public FrmAtualizarAgendamento()
        {
            InitializeComponent();
        }

        private void btnEscolherAgendamento_Click(object sender, EventArgs e)
        {
            // Lógica para escolher agendamento (a ser implementada)
        }

        private void btnEscolherCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEscolherFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void FrmAtualizarAgendamento_Load(object sender, EventArgs e)
        {
            var procedimentos = Procedimentos.ObterPorLista();
            cmbProcedimentos.DataSource = procedimentos;
            cmbProcedimentos.DisplayMember = "Nome";
            cmbProcedimentos.ValueMember = "Id";

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

        private void dgvConsultaAgendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pegue o nome do cliente da linha selecionada
                //AgendamentoSelecionado = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[1].Value.ToString();
                //IdAgendamentoSelecionado = Convert.ToInt32(dgvConsultaAgendamento.Rows[e.RowIndex].Cells[0].Value.ToString());

                TxtFuncionarios.Text = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[6].Value.ToString();
                TxtIdFuncionarios.Text = Convert.ToString(Convert.ToInt32(dgvConsultaAgendamento.Rows[e.RowIndex].Cells[5].Value.ToString()));
                TxtClientes.Text = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtIdClientes.Text = Convert.ToString(Convert.ToInt32(dgvConsultaAgendamento.Rows[e.RowIndex].Cells[3].Value.ToString()));
                TxtData.Text = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[1].Value.ToString();
                CMBHora.Text = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[1].Value.ToString();
                // Fecha o formulário após selecionar o cliente

            }
        }
    }
}
