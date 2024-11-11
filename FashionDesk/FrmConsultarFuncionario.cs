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
    public partial class FrmConsultarFuncionario : Form
    {
        public string FuncionarioSelecionado { get; private set; }
        public int IdFuncionarioSelecionado { get; set; }
        public string NomeFuncionarioInserir { get; private set; }
        public int IdFuncionairoInserir { get; set; }
        public FrmConsultarFuncionario()
        {
            InitializeComponent();
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

        private void CarregaGrid(string nome = "")
        {
            var lista = Funcionario.ObterPorLista(nome);
            dgvConsultarFuncionario.Rows.Clear();
            int cont = 0;
            foreach (var funcionario in lista)
            {
                dgvConsultarFuncionario.Rows.Add();
                dgvConsultarFuncionario.Rows[cont].Cells[0].Value = funcionario.Id;
                dgvConsultarFuncionario.Rows[cont].Cells[1].Value = funcionario.Nome;
                dgvConsultarFuncionario.Rows[cont].Cells[2].Value = funcionario.Email;
                dgvConsultarFuncionario.Rows[cont].Cells[3].Value = funcionario.Rg;
                dgvConsultarFuncionario.Rows[cont].Cells[4].Value = funcionario.Cpf;

                // Formatar a data para exibir apenas a data
                dgvConsultarFuncionario.Rows[cont].Cells[5].Value = funcionario.Data_Nasc.ToString("dd/MM/yyyy"); // Ou outro formato desejado

                dgvConsultarFuncionario.Rows[cont].Cells[6].Value = funcionario.Ativo ? "Sim" : "Não";
                dgvConsultarFuncionario.Rows[cont].Cells[7].Value = funcionario.Id_Cargo.Cargos;

                cont++;
            }
        }

        private void FrmConsultarFuncionario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            dgvConsultarFuncionario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnfecharForm_Click(object sender, EventArgs e)
        {
            FrmConsultarFuncionario frmConsultarFuncionario = new();
            frmConsultarFuncionario.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja continuar a consulta?",
                "Confirmação de saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.No) this.Close();
        }

        private void dgvConsultarFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pegue o nome do cliente da linha selecionada
                FuncionarioSelecionado = dgvConsultarFuncionario.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdFuncionarioSelecionado = Convert.ToInt32(dgvConsultarFuncionario.Rows[e.RowIndex].Cells[0].Value.ToString());
                NomeFuncionarioInserir = dgvConsultarFuncionario.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdFuncionairoInserir = Convert.ToInt32(dgvConsultarFuncionario.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Fecha o formulário após selecionar o cliente
                this.Close();
            }
        }
    }
}
