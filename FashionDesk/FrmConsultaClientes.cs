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
    public partial class FrmConsultaClientes : Form
    {
        public string ClienteSelecionado { get; private set; }
        public int IdClienteSelecionado { get; set; }
        public FrmConsultaClientes()
        {
            InitializeComponent();
        }

        private void btnfecharForm_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmConsultaClientes = new();
            frmConsultaClientes.Close();
        }

        private void FrmConsultaClientes_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            dgvConsultarCliente.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmConsultaClientes = new();
            frmConsultaClientes.Close();
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Cliente.ObterPorLista(nome);
            dgvConsultarCliente.Rows.Clear();
            int cont = 0;
            foreach (var funcionario in lista)
            {
                dgvConsultarCliente.Rows.Add();
                dgvConsultarCliente.Rows[cont].Cells[0].Value = funcionario.Id;
                dgvConsultarCliente.Rows[cont].Cells[1].Value = funcionario.Nome;
                dgvConsultarCliente.Rows[cont].Cells[2].Value = funcionario.Email;
                dgvConsultarCliente.Rows[cont].Cells[3].Value = funcionario.Cpf;

                // Formatar a data para exibir apenas a data
                dgvConsultarCliente.Rows[cont].Cells[4].Value = funcionario.Data_Nasc.ToString("dd/MM/yyyy"); // Ou outro formato desejado

                dgvConsultarCliente.Rows[cont].Cells[5].Value = funcionario.Ativo ? "Sim" : "Não";


                cont++;
            }
        }

        private void dgvConsultarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pegue o nome do cliente da linha selecionada
                ClienteSelecionado = dgvConsultarCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdClienteSelecionado = Convert.ToInt32(dgvConsultarCliente.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Fecha o formulário após selecionar o cliente
                this.Close();
            }

        }
    }
}
