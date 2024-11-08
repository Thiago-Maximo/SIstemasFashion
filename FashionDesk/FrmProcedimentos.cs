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
                dgvInserirProcedimentos.Rows[cont].Cells[4].Value = procedimento.Duracacao_Estimada.ToString(@"hh\:mm\:ss"); ;

                dgvInserirProcedimentos.Rows[cont].Cells[5].Value = procedimento.Classificacao;

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
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (txtClassificacao.TextLength > 1)
            {
                MessageBox.Show("A Classificação deve conter apenas 1 caracter");
            }

            Procedimentos procedimentos = new Procedimentos(
                txtnome.Text,
                txtDescricao.Text,
                nmrValor.Value,
                new TimeSpan(int.Parse(txtDuracaoEstimada.Text)),
                txtClassificacao.Text
                );


            procedimentos.Inserir();
            if (procedimentos.Id > 0)
            {
                MessageBox.Show($"O Cliente {procedimentos.Nome} com o Id {procedimentos.Id}, Foi Inserido com Sucesso!!");
                CarregaGrid();
            }
            else
            {
                MessageBox.Show("Falha ao Inserir Cliente");
                CarregaGrid();
            }
        }
    }
}
