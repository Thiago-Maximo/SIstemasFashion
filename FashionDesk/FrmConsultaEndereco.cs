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
        public string EnderecoSelecionado { get; private set; }
        public int IdEnderecoSelecionado { get; set; }
        public string NomeEnderecoInserir { get; private set; }
        public int IdEnderecoInserir { get; set; }
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
            dgvConsultarEndereco.Rows.Clear();
            int cont = 0;
            foreach (var endereco in lista)
            {
                dgvConsultarEndereco.Rows.Add();
                dgvConsultarEndereco.Rows[cont].Cells[0].Value = endereco.Id;
                dgvConsultarEndereco.Rows[cont].Cells[1].Value = endereco.Logradouro;
                dgvConsultarEndereco.Rows[cont].Cells[2].Value = endereco.Numero;
                dgvConsultarEndereco.Rows[cont].Cells[3].Value = endereco.Bairro;
                dgvConsultarEndereco.Rows[cont].Cells[4].Value = endereco.Cidade;
                dgvConsultarEndereco.Rows[cont].Cells[5].Value = endereco.Estado;
                dgvConsultarEndereco.Rows[cont].Cells[6].Value = endereco.Cep;
                dgvConsultarEndereco.Rows[cont].Cells[7].Value = endereco.Complemento;

                cont++;
            }
        }

        private void dgvEndereco_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula válida e não no cabeçalho
            if (e.RowIndex >= 0)
            {
                EnderecoSelecionado = dgvConsultarEndereco.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdEnderecoSelecionado = Convert.ToInt32(dgvConsultarEndereco.Rows[e.RowIndex].Cells[0].Value.ToString());
                NomeEnderecoInserir = dgvConsultarEndereco.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdEnderecoInserir = Convert.ToInt32(dgvConsultarEndereco.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Close();
            }
        }
    }
}
