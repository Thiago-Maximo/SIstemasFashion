using FashionLib;

namespace FashionDesk
{
    public partial class FrmInserirAgendamentos : Form
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

        public FrmInserirAgendamentos(DateTime data)
        {
            InitializeComponent();
            txtDate.Text = data.ToString("yyyy-MM-dd");
            CarregarHoras();
        }

        // Função para gerar lista de horários no formato string
        private List<string> GerarListaHoras()
        {
            List<string> horas = new List<string>();
            for (int hora = 9; hora <= 17; hora++)
            {
                horas.Add(hora.ToString("D2") + ":00");
            }
            return horas;
        }

        // Função para filtrar horários disponíveis
        private List<string> FiltrarHorasDisponiveis(DateTime data)
        {
            List<string> todasHoras = GerarListaHoras();
            List<string> horasAgendadas = Agendamentos.ObterHorasAgendadasPorData(data);
            List<string> horasDisponiveis = todasHoras.Except(horasAgendadas).ToList();
            return horasDisponiveis;
        }

        // Função para carregar horas disponíveis no ComboBox
        private void CarregarHoras()
        {
            cmbHora.Items.Clear();
            DateTime dataSelecionada = DateTime.Parse(txtDate.Text);
            List<string> horasDisponiveis = FiltrarHorasDisponiveis(dataSelecionada);

            foreach (string hora in horasDisponiveis)
            {
                cmbHora.Items.Add(hora);
            }
        }



        private void btnEscolherCliente_Click(object sender, EventArgs e)
        {
            using (FrmConsultaClientes frmConsultaClientes = new FrmConsultaClientes())
            {
                frmConsultaClientes.ShowDialog();

                if (!string.IsNullOrEmpty(frmConsultaClientes.ClienteSelecionado) || frmConsultaClientes.IdClienteSelecionado != 0)
                {
                    TxtClientes.Text = frmConsultaClientes.ClienteSelecionado;
                    txtIdClientes.Text = frmConsultaClientes.IdClienteSelecionado.ToString();
                }
            }
        }

        private void btnEscolherFuncionario_Click(object sender, EventArgs e)
        {
            if (cmbProcedimentos.SelectedValue == null || string.IsNullOrEmpty(cmbHora.Text))
            {
                MessageBox.Show("Por favor, selecione um procedimento e um horário primeiro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int procedimentoId = Convert.ToInt32(cmbProcedimentos.SelectedValue);
            DateTime data = DateTime.Parse(txtDate.Text);
            string hora = cmbHora.Text;

            using (FrmSelecionarFuncionario frmSelecionarFuncionario = new FrmSelecionarFuncionario(procedimentoId, data, hora, this))
            {
                frmSelecionarFuncionario.ShowDialog();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verifique se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrEmpty(TxtIdClientes.Text) ||
                string.IsNullOrEmpty(TxtIdFuncionarios.Text) ||
                string.IsNullOrEmpty(cmbProcedimentos.SelectedValue?.ToString()) ||
                string.IsNullOrEmpty(cmbHora.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios antes de confirmar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Cria um novo objeto de Agendamentos com os valores do formulário
                Agendamentos novoAgendamento = new Agendamentos
                {
                    Id_Cliente = int.Parse(TxtIdClientes.Text),
                    Id_Funcionario = int.Parse(TxtIdFuncionarios.Text),
                    Data_Agendamento = DateTime.Parse(txtDate.Text),
                    Hora_Agendamento = DateTime.Parse($"{txtDate.Text} {cmbHora.Text}"),
                    Id_procedimentos = int.Parse(cmbProcedimentos.SelectedValue.ToString())
                };

                // Insere o agendamento no banco de dados
                novoAgendamento.Inserir();

                // Confirmação de sucesso
                MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar os campos ou fechar o formulário, conforme necessário
                LimparCampos(); // Opcional, para limpar os campos
                this.Close(); // Fecha o formulário após a inserção
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Erro ao realizar o agendamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Função para limpar os campos do formulário (opcional)
        private void LimparCampos()
        {
            TxtClientes.Clear();
            TxtIdClientes.Clear();
            TxtFuncionarios.Clear();
            TxtIdFuncionarios.Clear();
            cmbHora.SelectedIndex = -1;
            cmbProcedimentos.SelectedIndex = -1;
        }

        private void FrmInserirAgendamentos_Load(object sender, EventArgs e)
        {
            var procedimentos = Procedimentos.ObterPorLista();
            cmbProcedimentos.DataSource = procedimentos;
            cmbProcedimentos.DisplayMember = "Nome";
            cmbProcedimentos.ValueMember = "Id";
        }
    }
}