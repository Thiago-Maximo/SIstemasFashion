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

        public Guna.UI2.WinForms.Guna2ComboBox CMBProcedimento
        {
            get { return cmbProcedimentos; }
        }

        public Guna.UI2.WinForms.Guna2TextBox TxtStatus
        {
            get { return txtStatus; }
        }

        public FrmAtualizarAgendamento()
        {
            InitializeComponent();
        }



        private void FrmAtualizarAgendamento_Load(object sender, EventArgs e)
        {
            var procedimentos = Procedimentos.ObterPorLista();
            cmbProcedimentos.DataSource = procedimentos;
            cmbProcedimentos.DisplayMember = "Nome";
            cmbProcedimentos.ValueMember = "Id";

            CarregaGrid();


        }

        public FrmAtualizarAgendamento(DateTime data)
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
        // Função para carregar horas disponíveis no ComboBox
        // Função para carregar horas disponíveis no ComboBox
        private void CarregarHoras()
        {
            cmbHora.Items.Clear();

            // Verificar se o campo txtDate não está vazio
            if (string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("A data selecionada está vazia. Por favor, selecione uma data válida.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tentar converter o texto do campo txtDate para DateTime
            DateTime dataSelecionada;
            bool conversaoValida = DateTime.TryParse(txtDate.Text, out dataSelecionada);

            if (!conversaoValida)
            {
                MessageBox.Show("A data fornecida não é válida. Por favor, use o formato de data correto (yyyy-MM-dd).", "Erro de Conversão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Carregar as horas disponíveis após a verificação
            List<string> horasDisponiveis = FiltrarHorasDisponiveis(dataSelecionada);

            foreach (string hora in horasDisponiveis)
            {
                cmbHora.Items.Add(hora);
            }

            // Verificar se o ComboBox possui itens
            if (cmbHora.Items.Count > 0)
            {
                cmbHora.SelectedIndex = 0; // Seleciona o primeiro item como padrão
            }
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
                TxtStatus.Text = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[8].Value.ToString();
                string procedimentoNome = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[7].Value.ToString();
                cmbProcedimentos.Text = procedimentoNome;

                // Obtém a hora do agendamento selecionado
                string horaAgendamento = dgvConsultaAgendamento.Rows[e.RowIndex].Cells[2].Value.ToString();

                // Verifica se a hora está na lista do ComboBox
                if (!cmbHora.Items.Contains(horaAgendamento))
                {
                    // Se a hora não estiver na lista, adiciona a hora para exibição
                    cmbHora.Items.Add(horaAgendamento);
                }

                // Define a hora como texto do ComboBox
                cmbHora.Text = horaAgendamento;
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            // Chama o método apenas se o campo de data não estiver vazio
            if (!string.IsNullOrWhiteSpace(txtDate.Text))
            {
                CarregarHoras();
            }
        }

        private void FrmAtualizarAgendamento_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDate.Text))
            {
                CarregarHoras();
            }
            CarregarProcedimentos();
        }

        // Função para carregar procedimentos no ComboBox com validação
        private void CarregarProcedimentos()
        {
            try
            {
                // Obter a lista de procedimentos
                var procedimentos = Procedimentos.ObterPorLista();

                // Verificar se existem procedimentos disponíveis
                if (procedimentos != null && procedimentos.Count > 0)
                {
                    // Desassociar o DataSource antes de limpar os itens
                    cmbProcedimentos.DataSource = null;
                    cmbProcedimentos.Items.Clear(); // Agora podemos limpar os itens

                    // Definir o DataSource após limpar
                    cmbProcedimentos.DataSource = procedimentos;
                    cmbProcedimentos.DisplayMember = "Nome";
                    cmbProcedimentos.ValueMember = "Id";

                    // Selecionar o primeiro item como padrão, se houver
                    if (cmbProcedimentos.Items.Count > 0)
                    {
                        cmbProcedimentos.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum procedimento encontrado. Por favor, adicione procedimentos antes de continuar.", "Procedimentos Não Encontrados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar procedimentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaAgendamento frmConsultaAgendamento = new();
            frmConsultaAgendamento.ShowDialog();
        }
    }
}
