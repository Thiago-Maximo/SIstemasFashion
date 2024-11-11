﻿using FashionLib;
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
    public partial class FrmInserirCliente : Form
    {
        public FrmInserirCliente()
        {
            InitializeComponent();
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Cliente.ObterPorLista(nome);
            dgvClientesInserir.Rows.Clear();
            int cont = 0;
            foreach (var cliente in lista)
            {
                dgvClientesInserir.Rows.Add();
                dgvClientesInserir.Rows[cont].Cells[0].Value = cliente.Id;
                dgvClientesInserir.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvClientesInserir.Rows[cont].Cells[2].Value = cliente.Email;
                dgvClientesInserir.Rows[cont].Cells[3].Value = cliente.Cpf;

                // Formatar a data para exibir apenas a data
                dgvClientesInserir.Rows[cont].Cells[4].Value = cliente.Data_Nasc.ToString("dd/MM/yyyy"); // Ou outro formato desejado

                dgvClientesInserir.Rows[cont].Cells[5].Value = cliente.Ativo ? "Sim" : "Não";

                cont++;
            }
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


        private void FrmInserirCliente_Load(object sender, EventArgs e)
        {
            // Configuração do MaskedTextBox para CPF
            mskCpf.Mask = "000.000.000-00";
            mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            CarregaGrid();
            //dgvClientesInserir.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            // Extrair CPF
            string cpfNumeros = new string(mskCpf.Text.Where(char.IsDigit).ToArray());

            // Verificar se o CPF tem o número correto de dígitos
            if (cpfNumeros.Length != 11)
            {
                MessageBox.Show("O campo CPF deve conter 11 dígitos.");
                return;
            }


            Cliente cliente = new Cliente(
                txtNome.Text,
                cpfNumeros,
                dateData_Nasc.Value,
                txtEmail.Text
                );


            cliente.Inserir();
            if (cliente.Id > 0)
            {
                MessageBox.Show($"O Cliente {cliente.Nome} com o Id {cliente.Id}, Foi Inserido com Sucesso!!");
                CarregaGrid();
            }
            else
            {
                MessageBox.Show("Falha ao Inserir Cliente");
                CarregaGrid();
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            if (VerificandoControles())
            {
                var msg = MessageBox.Show("Deseja continuar o cadastro?",
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



            FrmInserirCliente frmInserirCliente = new();
            frmInserirCliente.Close();


        }
    }
}
