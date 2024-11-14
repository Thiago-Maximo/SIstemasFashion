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
    public partial class FrmCargos : Form
    {
        public FrmCargos()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text.Length > 0)
            {
                Cargo cargos = new(
                TxtNome.Text
                );

                cargos.Inserir();
                if (cargos.Id > 0)
                {
                    MessageBox.Show($"Sucesso Ao Inserir o Cargo {cargos.Cargos}, foi inserido com o ID {cargos.Id}");
                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Falha Ao Tentar Inserir o Cargo");
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Por Favor Preencha o Campo");
                CarregaGrid();
            }

        }

        private void FrmCargos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaGridCargoAtualizado();
            CarregaGridConsulta();
        }

        private void CarregaGrid(string cargos = "")
        {
            var lista = Cargo.ObterPorLista(cargos);
            dgvInserirCargos.Rows.Clear();
            int cont = 0;
            foreach (var cargo in lista)
            {
                dgvInserirCargos.Rows.Add();
                dgvInserirCargos.Rows[cont].Cells[0].Value = cargo.Id;
                dgvInserirCargos.Rows[cont].Cells[1].Value = cargo.Cargos;

                cont++;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {


            Cargo cargos = new(
                Convert.ToInt32(TxtIdAtualizado.Text),
                TxtNomeAtualizado.Text
            );

            cargos.Atualizar();
            if (cargos.Id > 0)
            {
                MessageBox.Show($"Sucesso Ao Atualizar o Cargo {cargos.Cargos},  com o ID {cargos.Id}");
                CarregaGridCargoAtualizado();
                CarregaGrid();
            }
            else
            {
                MessageBox.Show("Falha Ao Tentar Atualizar o Cargo");
                CarregaGridCargoAtualizado();
                CarregaGrid();
            }


        }
        private void CarregaGridCargoAtualizado(string cargos = "")
        {
            var lista = Cargo.ObterPorLista(cargos);
            dgvAtulizaCargo.Rows.Clear();
            int cont = 0;
            foreach (var cargo in lista)
            {
                dgvAtulizaCargo.Rows.Add();
                dgvAtulizaCargo.Rows[cont].Cells[0].Value = cargo.Id;
                dgvAtulizaCargo.Rows[cont].Cells[1].Value = cargo.Cargos;

                cont++;
            }
        }

        private void dgvAtulizaCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAtulizaCargo.Rows[e.RowIndex];

                // Preenche os TextBox com os dados da linha selecionada
                TxtIdAtualizado.Text = row.Cells[0].Value?.ToString();
                TxtNomeAtualizado.Text = row.Cells[1].Value?.ToString();
            }
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            if (txtConsultar.Text.Length > 0)
            {
                CarregaGridConsulta(txtConsultar.Text);
            }
            else
            {
                CarregaGridConsulta();
            }
        }

        private void CarregaGridConsulta(string cargos = "")
        {
            var lista = Cargo.ObterPorLista(cargos);
            dgvConsultaCargo.Rows.Clear();
            int cont = 0;
            foreach (var cargo in lista)
            {
                dgvConsultaCargo.Rows.Add();
                dgvConsultaCargo.Rows[cont].Cells[0].Value = cargo.Id;
                dgvConsultaCargo.Rows[cont].Cells[1].Value = cargo.Cargos;

                cont++;
            }
        }
    }
}
