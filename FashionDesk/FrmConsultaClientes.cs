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
    public partial class FrmConsultaClientes : Form
    {
        public FrmConsultaClientes()
        {
            InitializeComponent();
        }

        private void btnfecharForm_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmConsultaClientes = new();
            frmConsultaClientes.Close();
        }

        private void FrmConsultaClientes_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            dgvConsultarFuncionario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            if (txtConsultar.Text.Length > 0)
            {
                CarregaGrid(txtConsultar.Text);
            }
            else
            {
                CarregaGrid();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja continuar a consulta?",
                   "Confirmação de saída",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.No) this.Close();
        }
    }
}
