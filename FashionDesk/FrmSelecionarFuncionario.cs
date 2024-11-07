using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using FashionLib;

namespace FashionDesk
{
    public partial class FrmSelecionarFuncionario : Form
    {
        public int IdFuncionarioSelecionado { get; private set; }
        public string FuncionarioSelecionado { get; private set; }
        private FrmInserirAgendamentos _frmInserirAgendamentos;

        public FrmSelecionarFuncionario(int procedimentoId, DateTime data, string hora, FrmInserirAgendamentos frmInserirAgendamentos)
        {
            InitializeComponent();
            CarregarFuncionariosDisponiveis(procedimentoId, data, hora);
            _frmInserirAgendamentos = frmInserirAgendamentos;
        }

        private void CarregarFuncionariosDisponiveis(int procedimentoId, DateTime data, string hora)
        {
            var funcionariosDisponiveis = Funcionario.ObterFuncionariosPorProcedimento(procedimentoId)
                .Where(f => !Agendamentos.ObterHorasAgendadasPorDataFuncionario(data, f.Id).Contains(hora))
                .ToList();

            dgvSelecionarFuncionario.Rows.Clear();
            foreach (var funcionario in funcionariosDisponiveis)
            {
                int rowIndex = dgvSelecionarFuncionario.Rows.Add();
                dgvSelecionarFuncionario.Rows[rowIndex].Cells[0].Value = funcionario.Id;
                dgvSelecionarFuncionario.Rows[rowIndex].Cells[1].Value = funcionario.Nome;
                dgvSelecionarFuncionario.Rows[rowIndex].Cells[2].Value = funcionario.Email;
                dgvSelecionarFuncionario.Rows[rowIndex].Cells[3].Value = funcionario.Rg;
                dgvSelecionarFuncionario.Rows[rowIndex].Cells[4].Value = funcionario.Cpf;
                dgvSelecionarFuncionario.Rows[rowIndex].Cells[5].Value = funcionario.Data_Nasc;
                dgvSelecionarFuncionario.Rows[rowIndex].Cells[6].Value = funcionario.Ativo;
                dgvSelecionarFuncionario.Rows[rowIndex].Cells[7].Value = funcionario.Id_Cargo.Cargos;
            }
        }

        private void dgvSelecionarFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdFuncionarioSelecionado = Convert.ToInt32(dgvSelecionarFuncionario.Rows[e.RowIndex].Cells[0].Value);
                FuncionarioSelecionado = dgvSelecionarFuncionario.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Atualiza os TextBoxes no FrmInserirAgendamentos com os dados do funcionário selecionado
                _frmInserirAgendamentos.TxtIdFuncionarios.Text = IdFuncionarioSelecionado.ToString();
                _frmInserirAgendamentos.TxtFuncionarios.Text = FuncionarioSelecionado;

                this.Close();
            }
        }
    }
}
