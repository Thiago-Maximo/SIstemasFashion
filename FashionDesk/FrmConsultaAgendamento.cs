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
    public partial class FrmConsultaAgendamento : Form
    {
        public FrmConsultaAgendamento()
        {
            InitializeComponent();
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
                dgvConsultaAgendamento.Rows[cont].Cells[3].Value = agendamentos.Id_Cliente.Nome;
                dgvConsultaAgendamento.Rows[cont].Cells[4].Value = agendamentos.Id_Funcionario.Nome;

                // Formatar a data para exibir apenas a data
                dgvConsultaAgendamento.Rows[cont].Cells[1].Value = agendamentos.Data_Agendamento.ToString("dd/MM/yyyy"); // Ou outro formato desejado
                dgvConsultaAgendamento.Rows[cont].Cells[2].Value = agendamentos.Hora_Agendamento.ToString(@"hh\:mm\:ss");

                dgvConsultaAgendamento.Rows[cont].Cells[5].Value = agendamentos.Id_procedimentos.Nome;
                dgvConsultaAgendamento.Rows[cont].Cells[6].Value = agendamentos.Status;


                cont++;
            }
        }

        private void FrmConsultaAgendamento_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnfecharForm_Click(object sender, EventArgs e)
        {
            FrmConsultaAgendamento frmConsultaAgendamento = new();
            frmConsultaAgendamento.Close();
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
    }
}
