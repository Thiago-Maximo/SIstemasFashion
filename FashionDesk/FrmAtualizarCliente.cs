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
    public partial class FrmAtualizarCliente : Form
    {
        public FrmAtualizarCliente()
        {
            InitializeComponent();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                CarregaGrid();
            }
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Cliente.ObterPorLista(nome);
            dgvClientesAtualizar.Rows.Clear();
            int cont = 0;
            foreach (var cliente in lista)
            {
                dgvClientesAtualizar.Rows.Add();
                dgvClientesAtualizar.Rows[cont].Cells[0].Value = cliente.Id;
                dgvClientesAtualizar.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvClientesAtualizar.Rows[cont].Cells[2].Value = cliente.Email;
                dgvClientesAtualizar.Rows[cont].Cells[3].Value = cliente.Cpf;

                // Formatar a data para exibir apenas a data
                dgvClientesAtualizar.Rows[cont].Cells[4].Value = cliente.Data_Nasc.ToString("dd/MM/yyyy"); // Ou outro formato desejado

                dgvClientesAtualizar.Rows[cont].Cells[5].Value = cliente.Ativo ? "Sim" : "Não";
                cont++;
            }
        }

        private void FrmAtualizarCliente_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            // Configuração dos MaskedTextBox para RG e CPF
            
            mskCpf.Mask = "000.000.000-00";
            mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            // Carrega os funcionários no DataGridView
            CarregaGrid();
            dgvClientesAtualizar.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Extrair CPF

            string cpfNumeros = new string(mskCpf.Text.Where(char.IsDigit).ToArray());

            // Verificar se o CPF tem o número correto de dígitos
            if (cpfNumeros.Length != 11)
            {
                MessageBox.Show("O campo CPF deve conter 11 dígitos.");
                return;
            }

            Cliente cliente = new Cliente(
                Convert.ToInt32(txtId.Text),
                 txtNome.Text,
                 cpfNumeros,
                 dateData_Nasc.Value,
                 chkAtivo.Checked,
                 txtEmail.Text
             );

            cliente.Atualizar();

            // Recarrega a grid após a atualização
            CarregaGrid();

            if (cliente.Id > 0)
            {
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O Cliente {cliente.Nome} com o Id {cliente.Id}, Foi Atualizado com Sucesso!!");
                CarregaGrid();
                txtNome.Clear();
                txtEmail.Clear();
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Falha ao Atualizar Cliente");
                CarregaGrid();
            }
        }

        private void dgvClientesAtualizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula válida e não no cabeçalho
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientesAtualizar.Rows[e.RowIndex];

                // Preenche os TextBox com os dados da linha selecionada
                txtId.Text = row.Cells[0].Value?.ToString();
                txtNome.Text = row.Cells[1].Value?.ToString();
                txtEmail.Text = row.Cells[2].Value?.ToString();

                // Define o RG e CPF nos MaskedTextBox
                
                mskCpf.Text = row.Cells[3].Value?.ToString().Replace(".", "").Replace("-", "");

                // Conversão da data de nascimento para o DateTimePicker
                if (DateTime.TryParse(row.Cells[4].Value?.ToString(), out DateTime dataNascimento))
                {
                    dateData_Nasc.Value = dataNascimento;
                }
                else
                {
                    dateData_Nasc.Value = DateTime.Today; // Define uma data padrão caso a conversão falhe
                }

                // Configura o checkbox de Ativo
                chkAtivo.Checked = row.Cells[5].Value?.ToString() == "Ativo";
            }
        }
    }
}
