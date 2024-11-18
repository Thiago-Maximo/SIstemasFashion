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
    public partial class FrmConsultaEndereco : Form
    {
        public FrmConsultaEndereco()
        {
            InitializeComponent();
        }

        private void FrmConsultaEndereco_Load(object sender, EventArgs e)
        {
            CarregaGridEndereco();
        }
        private void CarregaGridEndereco()
        {
            var lista = Endereco.ObterPorLista();
            dgvEndereco.Rows.Clear();
            int cont = 0;
            foreach (var endereco in lista)
            {
                dgvEndereco.Rows.Add();
                dgvEndereco.Rows[cont].Cells[0].Value = endereco.Id;
                dgvEndereco.Rows[cont].Cells[1].Value = endereco.Logradouro;
                dgvEndereco.Rows[cont].Cells[2].Value = endereco.Numero;
                dgvEndereco.Rows[cont].Cells[3].Value = endereco.Bairro;
                dgvEndereco.Rows[cont].Cells[4].Value = endereco.Cidade;
                dgvEndereco.Rows[cont].Cells[5].Value = endereco.Estado;
                dgvEndereco.Rows[cont].Cells[6].Value = endereco.Cep;
                dgvEndereco.Rows[cont].Cells[7].Value = endereco.Complemento;

                cont++;
            }
        }

        private void dgvEndereco_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula válida e não no cabeçalho
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = dgvFuncionariosProcedimentos.Rows[e.RowIndex];


                //txtIdFuncProd.Text = row.Cells[0].Value?.ToString();
                //TxtNomeFunc.Text = row.Cells[1].Value?.ToString();
                //TxtNomeProc.Text = row.Cells[2].Value?.ToString();
                //txtIdProc.Text = row.Cells[3].Value?.ToString();
                //txtIdFunc.Text = row.Cells[4].Value?.ToString();
            }
        }
    }
}
