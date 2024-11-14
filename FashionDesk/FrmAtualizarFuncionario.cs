using FashionLib;
using MySqlX.XDevAPI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FashionDesk
{
    public partial class FrmAtualizarFuncionario : Form
    {
        public Guna.UI2.WinForms.Guna2TextBox TxtNomeFunc
        {
            get { return txtNomeFunc; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtIdFunc
        {
            get { return txtIdFunc; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtNomeProc
        {
            get { return txtProcedimento; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtIdProc
        {
            get { return txtIdProc; }
        }
        public FrmAtualizarFuncionario()
        {
            InitializeComponent();
        }

        private void FrmAtualizarFuncionario_Load(object sender, EventArgs e)
        {
            // Carrega os cargos no ComboBox
            var Cargos = Cargo.ObterPorLista();
            cmbCargo.DataSource = Cargos;
            cmbCargo.DisplayMember = "Cargos";
            cmbCargo.ValueMember = "Id";

            // Configuração dos MaskedTextBox para RG e CPF
            mskRg.Mask = "00.000.000-0";
            mskRg.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mskCpf.Mask = "000.000.000-00";
            mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            // Carrega os funcionários no DataGridView
            CarregaGrid();
            dgvFuncionariosAtualizar.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            var FuncionarioProcedimentos = FuncionarioProcedimento.ObterPorLista();
            CarregaGridFuncProd();

            
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Funcionario.ObterPorLista(nome);
            dgvFuncionariosAtualizar.Rows.Clear();
            int cont = 0;
            foreach (var funcionario in lista)
            {
                dgvFuncionariosAtualizar.Rows.Add();
                dgvFuncionariosAtualizar.Rows[cont].Cells[0].Value = funcionario.Id;
                dgvFuncionariosAtualizar.Rows[cont].Cells[1].Value = funcionario.Nome;
                dgvFuncionariosAtualizar.Rows[cont].Cells[2].Value = funcionario.Email;
                dgvFuncionariosAtualizar.Rows[cont].Cells[3].Value = funcionario.Rg;
                dgvFuncionariosAtualizar.Rows[cont].Cells[4].Value = funcionario.Cpf;

                // Formatar a data para exibir apenas a data
                dgvFuncionariosAtualizar.Rows[cont].Cells[5].Value = funcionario.Data_Nasc.ToString("dd/MM/yyyy"); // Ou outro formato desejado

                dgvFuncionariosAtualizar.Rows[cont].Cells[6].Value = funcionario.Ativo ? "Sim" : "Não";
                dgvFuncionariosAtualizar.Rows[cont].Cells[7].Value = funcionario.Id_Cargo.Cargos;

                cont++;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Extrair RG e CPF
            string rgNumeros = new string(mskRg.Text.Where(char.IsDigit).ToArray());
            string cpfNumeros = new string(mskCpf.Text.Where(char.IsDigit).ToArray());

            // Verificar se o RG tem o número correto de dígitos
            if (rgNumeros.Length != 9)
            {
                MessageBox.Show("O campo RG deve conter 9 dígitos.");
                return;
            }

            // Verificar se o CPF tem o número correto de dígitos
            if (cpfNumeros.Length != 11)
            {
                MessageBox.Show("O campo CPF deve conter 11 dígitos.");
                return;
            }

            // Obter id_cargo
            int cargoId = Convert.ToInt32(cmbCargo.SelectedValue);
            var cargo = Cargo.ObterPorId(cargoId);
            if (cargo == null)
            {
                MessageBox.Show("O cargo selecionado não é válido. Por favor, selecione um cargo existente.");
                return;
            }

            Funcionario funcionario = new Funcionario(
                Convert.ToInt32(txtId.Text),
                 txtNome.Text,
                 rgNumeros,
                 cpfNumeros,
                 dateData_Nasc.Value,
                 Cargo.ObterPorId(cargoId),// Passa o cargo válido
                 chkAtivo.Checked,
                 txtEmail.Text
             );

            funcionario.Atualizar();

            CarregaGrid();
            if (funcionario.Id > 0)
            {
                txtId.Text = funcionario.Id.ToString();
                MessageBox.Show($"O Funcionario {funcionario.Nome} com o Id {funcionario.Id}, Foi Atualizado com Sucesso!!");
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

        private void dgvFuncionariosInserir_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula válida e não no cabeçalho
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFuncionariosAtualizar.Rows[e.RowIndex];

                // Preenche os TextBox com os dados da linha selecionada
                txtId.Text = row.Cells[0].Value?.ToString();
                txtNome.Text = row.Cells[1].Value?.ToString();
                txtEmail.Text = row.Cells[2].Value?.ToString();

                // Define o RG e CPF nos MaskedTextBox
                mskRg.Text = row.Cells[3].Value?.ToString().Replace(".", "").Replace("-", "");
                mskCpf.Text = row.Cells[4].Value?.ToString().Replace(".", "").Replace("-", "");

                // Conversão da data de nascimento para o DateTimePicker
                if (DateTime.TryParse(row.Cells[5].Value?.ToString(), out DateTime dataNascimento))
                {
                    dateData_Nasc.Value = dataNascimento;
                }
                else
                {
                    dateData_Nasc.Value = DateTime.Today; // Define uma data padrão caso a conversão falhe
                }

                // Configura o checkbox de Ativo
                chkAtivo.Checked = row.Cells[6].Value?.ToString() == "Ativo";
            }
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (VerificandoControles())
            {
                var msg = MessageBox.Show("Deseja continuar a atualização ?",
                    "Confirmação de saída",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.No) this.Close();
            }
            else { this.Close(); }
        }

        private void btnfecharForm_Click(object sender, EventArgs e)
        {
            FrmAtualizarFuncionario frmAtualizarFuncionario = new();
            frmAtualizarFuncionario.Close();
        }

        private bool VerificandoControles()
        {
            if (txtNome.Text != string.Empty ||
                mskCpf.Text != string.Empty ||
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

        private void btnInserirFuncProc_Click(object sender, EventArgs e)
        {
            FuncionarioProcedimento funcionarioProcedimento = new FuncionarioProcedimento
            {
                Id_funcionario = Funcionario.ObterPorId(int.Parse(txtIdFunc.Text)),
                Id_Procedimentos = Procedimentos.ObterPorId(int.Parse(txtIdProc.Text))
            };

            funcionarioProcedimento.Atualizar();
            if (funcionarioProcedimento.Id > 0)
            {
                MessageBox.Show("Sucesso");

                CarregaGridFuncProd();
            }
            else
            {
                MessageBox.Show("Falha");
                CarregaGridFuncProd();
            }
        }
        private void CarregaGridFuncProd()
        {
            var lista = FuncionarioProcedimento.ObterPorLista();
            dgvFuncionariosProcedimentos.Rows.Clear();
            int cont = 0;
            foreach (var funcionarioProcedimentos in lista)
            {
                dgvFuncionariosProcedimentos.Rows.Add();
                dgvFuncionariosProcedimentos.Rows[cont].Cells[0].Value = funcionarioProcedimentos.Id;
                dgvFuncionariosProcedimentos.Rows[cont].Cells[1].Value = funcionarioProcedimentos.Id_funcionario.Nome;
                dgvFuncionariosProcedimentos.Rows[cont].Cells[2].Value = funcionarioProcedimentos.Id_Procedimentos.Nome;

                cont++;
            }
        }

        private void btnEscolherFuncionario_Click(object sender, EventArgs e)
        {
            using (FrmConsultarFuncionario frmConsultaFuncionario = new FrmConsultarFuncionario())
            {
                frmConsultaFuncionario.ShowDialog();

                if (!string.IsNullOrEmpty(frmConsultaFuncionario.FuncionarioSelecionado) || frmConsultaFuncionario.IdFuncionarioSelecionado != 0)
                {
                    TxtNomeFunc.Text = frmConsultaFuncionario.NomeFuncionarioInserir;
                    TxtIdFunc.Text = frmConsultaFuncionario.IdFuncionairoInserir.ToString();
                }
            }
        }

        private void btnEscolherProcedimento_Click(object sender, EventArgs e)
        {
            using (FrmProcedimentos frmProcedimentos = new FrmProcedimentos())
            {
                frmProcedimentos.ShowDialog();

                if (!string.IsNullOrEmpty(frmProcedimentos.ProcedimentoSelecionado) || frmProcedimentos.IdProcedimentoSelecionado != 0)
                {
                    TxtNomeProc.Text = frmProcedimentos.NomeProcedimentoInserir;
                    TxtIdProc.Text = frmProcedimentos.IdProcedimentoInserir.ToString();
                }
            }
        }
    }
}