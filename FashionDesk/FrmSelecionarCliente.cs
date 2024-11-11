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
    public partial class FrmSelecionarCliente : Form
    {
        public string ClienteSelecionado { get; private set; }
        public int IdClienteSelecionado { get; set; }

        public FrmSelecionarCliente()
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

        private void dgvConsultarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pegue o nome do cliente da linha selecionada
                ClienteSelecionado = dgvSelecionarCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdClienteSelecionado = Convert.ToInt32(dgvSelecionarCliente.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Fecha o formulário após selecionar o cliente
                this.Close();
            }
        }

        private void FrmSelecionarCliente_Load(object sender, EventArgs e)
        {

            CarregaGrid();
            dgvSelecionarCliente.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FrmSelecionarCliente frmSelecionarCliente = new();
            frmSelecionarCliente.Close();
        }

        private void CarregaGrid(string nome = "")
        {
            // Obter lista de clientes, talvez você precise de uma filtragem adicional no método 'ObterPorLista'
            var lista = Cliente.ObterPorLista(nome);

            // Limpar as linhas existentes no DataGridView
            dgvSelecionarCliente.Rows.Clear();
            int cont = 0;

            foreach (var cliente in lista)
            {
                // Verificar se o cliente está ativo
                if (!cliente.Ativo)
                {
                    continue; // Se não estiver ativo, pular para o próximo cliente
                }

                // Adiciona o cliente ativo à grid
                dgvSelecionarCliente.Rows.Add();
                dgvSelecionarCliente.Rows[cont].Cells[0].Value = cliente.Id;
                dgvSelecionarCliente.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvSelecionarCliente.Rows[cont].Cells[2].Value = cliente.Email;
                dgvSelecionarCliente.Rows[cont].Cells[3].Value = cliente.Cpf;

                // Formatar a data para exibir apenas a data
                dgvSelecionarCliente.Rows[cont].Cells[4].Value = cliente.Data_Nasc.ToString("dd/MM/yyyy");

                // Mostrar o status de ativo (pode ser 'Sim' ou 'Não' dependendo de sua necessidade)
                dgvSelecionarCliente.Rows[cont].Cells[5].Value = cliente.Ativo ? "Sim" : "Não";

                cont++;
            }
        }

    }
}

