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
    public partial class FrmProcedimentos : Form
    {
        public string ProcedimentoSelecionado { get; set; }
        public int IdProcedimentoSelecionado { get; set; }
        public string NomeProcedimentoInserir { get; set; }
        public int IdProcedimentoInserir { get; set; }


        public FrmProcedimentos()
        {
            InitializeComponent();
        }

        private void btnfecharForm_Click(object sender, EventArgs e)
        {
            FrmProcedimentos frmProcedimentos = new();
            frmProcedimentos.Close();
        }

        private void CarregaGrid(string procedimentos = "")
        {
            var lista = Procedimentos.ObterPorLista(procedimentos);
            dgvInserirProcedimentos.Rows.Clear();
            int cont = 0;
            foreach (var procedimento in lista)
            {
                dgvInserirProcedimentos.Rows.Add();
                dgvInserirProcedimentos.Rows[cont].Cells[0].Value = procedimento.Id;
                dgvInserirProcedimentos.Rows[cont].Cells[1].Value = procedimento.Nome;
                dgvInserirProcedimentos.Rows[cont].Cells[2].Value = procedimento.Descricao;
                dgvInserirProcedimentos.Rows[cont].Cells[3].Value = procedimento.Valor;


                dgvInserirProcedimentos.Rows[cont].Cells[4].Value = procedimento.Classificacao;

                cont++;
            }
        }

        private void CarregaGridAtualizar(string procedimentos = "")
        {
            var lista = Procedimentos.ObterPorLista(procedimentos);
            dgvAtualizarProcedimento.Rows.Clear();
            int cont = 0;
            foreach (var procedimento in lista)
            {
                dgvAtualizarProcedimento.Rows.Add();
                dgvAtualizarProcedimento.Rows[cont].Cells[0].Value = procedimento.Id;
                dgvAtualizarProcedimento.Rows[cont].Cells[1].Value = procedimento.Nome;
                dgvAtualizarProcedimento.Rows[cont].Cells[2].Value = procedimento.Descricao;
                dgvAtualizarProcedimento.Rows[cont].Cells[3].Value = procedimento.Valor;


                dgvAtualizarProcedimento.Rows[cont].Cells[4].Value = procedimento.Classificacao;

                cont++;
            }
        }

        private void tbpgInserirProcedimentos_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmProcedimentos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaGridAtualizar();
        }

        private void dgvInserirProcedimentos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pegue o nome do cliente da linha selecionada
                ProcedimentoSelecionado = dgvInserirProcedimentos.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdProcedimentoSelecionado = Convert.ToInt32(dgvInserirProcedimentos.Rows[e.RowIndex].Cells[0].Value.ToString());
                NomeProcedimentoInserir = dgvInserirProcedimentos.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdProcedimentoInserir = Convert.ToInt32(dgvInserirProcedimentos.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Fecha o formulário após selecionar o cliente
                this.Close();
            }
        }

        private void dgvAtualizarProcedimento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifica se o clique foi em uma célula válida e não no cabeçalho
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAtualizarProcedimento.Rows[e.RowIndex];


                TxtIDProcedimento.Text = row.Cells[0].Value?.ToString();
                TxtNomeAtualizado.Text = row.Cells[1].Value?.ToString();
                TxtDescricaoAtualizado.Text = row.Cells[2].Value?.ToString();
                TxtClassificacaoAtualizado.Text = row.Cells[4].Value?.ToString();
                nmrValorAtualizado.Text = row.Cells[3].Value?.ToString();
            }
        }
    }
}
