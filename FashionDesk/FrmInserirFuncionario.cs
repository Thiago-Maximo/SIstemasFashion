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
    public partial class FrmInserirFuncionario : Form
    {
        public FrmInserirFuncionario()
        {
            InitializeComponent();
        }

        private void btnfecharForm_Click(object sender, EventArgs e)
        {
            FrmInserirFuncionario frmInserirFuncionario = new();
            frmInserirFuncionario.Close();
        }

        private void FrmInserirFuncionario_Load(object sender, EventArgs e)
        {
            var Cargos = Cargo.ObterPorLista();
            cmbCargo.DataSource = Cargos;
            cmbCargo.DisplayMember = "Cargos";
            cmbCargo.ValueMember = "Id";


            // Configuração do MaskedTextBox para RG
            mskRg.Mask = "00.000.000-0";
            mskRg.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            // Configuração do MaskedTextBox para CPF
            mskCpf.Mask = "000.000.000-00";
            mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            CarregaGrid();
            dgvFuncionariosInserir.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Extrair RG e CPF
            string rgNumeros = new string(mskRg.Text.Where(char.IsDigit).ToArray());
            string cpfNumeros = new string(mskCpf.Text.Where(char.IsDigit).ToArray());

            // Obter id_cargo
            int cargoId = Convert.ToInt32(cmbCargo.SelectedValue);
            if (Cargo.ObterPorId(cargoId) == null)
            {
                MessageBox.Show("O cargo selecionado não é válido. Por favor, selecione um cargo existente.");
                return;
            }

            Funcionario funcionario = new Funcionario(
                txtNome.Text,
                rgNumeros,
                cpfNumeros,
                dateData_Nasc.Value,
                Cargo.ObterPorId(cargoId) // Passa o cargo válido
            );


            funcionario.Inserir();
            if (funcionario.Id > 0)
            {
                MessageBox.Show($"O Funcionario {funcionario.Nome} com o Id {funcionario.Id}, Foi Inserindo com Sucesso!!");
                CarregaGrid();
            }
            else
            {
                MessageBox.Show("Falha ao Inserir Funcionario");
                CarregaGrid();
            }
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Funcionario.ObterPorLista(nome);
            dgvFuncionariosInserir.Rows.Clear();
            int cont = 0;
            foreach (var funcionario in lista)
            {
                dgvFuncionariosInserir.Rows.Add();
                dgvFuncionariosInserir.Rows[cont].Cells[0].Value = funcionario.Id;
                dgvFuncionariosInserir.Rows[cont].Cells[1].Value = funcionario.Nome;
                dgvFuncionariosInserir.Rows[cont].Cells[2].Value = funcionario.Rg;
                dgvFuncionariosInserir.Rows[cont].Cells[3].Value = funcionario.Cpf;

                // Formatar a data para exibir apenas a data
                dgvFuncionariosInserir.Rows[cont].Cells[4].Value = funcionario.Data_Nasc.ToString("dd/MM/yyyy"); // Ou outro formato desejado

                dgvFuncionariosInserir.Rows[cont].Cells[5].Value = funcionario.Ativo;
                dgvFuncionariosInserir.Rows[cont].Cells[6].Value = funcionario.Id_Cargo.Cargos;

                cont++;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (VerificandoControles())
            {
                var msg = MessageBox.Show("Deseja continuar o cadastro?",
                    "Confirmação de saída",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.No) this.Close();
            }
            else { this.Close(); }
        }

        private bool VerificandoControles()
        {
            if (txtNome.Text != string.Empty ||
                mskCpf.Text != string.Empty ||
                mskRg.Text != string.Empty ||
                dateData_Nasc.Text != string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
