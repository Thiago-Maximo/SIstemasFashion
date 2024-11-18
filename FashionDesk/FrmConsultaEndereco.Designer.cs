namespace FashionDesk
{
    partial class FrmConsultaEndereco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvEndereco = new Guna.UI2.WinForms.Guna2DataGridView();
            clnIdEndereço = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnEstado = new DataGridViewTextBoxColumn();
            clnCep = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).BeginInit();
            SuspendLayout();
            // 
            // dgvEndereco
            // 
            dgvEndereco.AllowUserToAddRows = false;
            dgvEndereco.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvEndereco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEndereco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEndereco.ColumnHeadersHeight = 17;
            dgvEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEndereco.Columns.AddRange(new DataGridViewColumn[] { clnIdEndereço, clnLogradouro, clnNumero, clnBairro, clnCidade, clnEstado, clnCep, clnComplemento });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEndereco.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEndereco.GridColor = Color.FromArgb(231, 229, 255);
            dgvEndereco.Location = new Point(30, 168);
            dgvEndereco.Name = "dgvEndereco";
            dgvEndereco.ReadOnly = true;
            dgvEndereco.RowHeadersVisible = false;
            dgvEndereco.RowHeadersWidth = 51;
            dgvEndereco.Size = new Size(746, 270);
            dgvEndereco.TabIndex = 7;
            dgvEndereco.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEndereco.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEndereco.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEndereco.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEndereco.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEndereco.ThemeStyle.BackColor = Color.White;
            dgvEndereco.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvEndereco.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvEndereco.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEndereco.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvEndereco.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEndereco.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEndereco.ThemeStyle.HeaderStyle.Height = 17;
            dgvEndereco.ThemeStyle.ReadOnly = true;
            dgvEndereco.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEndereco.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEndereco.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvEndereco.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEndereco.ThemeStyle.RowsStyle.Height = 25;
            dgvEndereco.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEndereco.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvEndereco.CellContentDoubleClick += dgvEndereco_CellContentDoubleClick;
            // 
            // clnIdEndereço
            // 
            clnIdEndereço.HeaderText = "Id";
            clnIdEndereço.MinimumWidth = 6;
            clnIdEndereço.Name = "clnIdEndereço";
            clnIdEndereço.ReadOnly = true;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.MinimumWidth = 6;
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            // 
            // clnNumero
            // 
            clnNumero.HeaderText = "Número";
            clnNumero.MinimumWidth = 6;
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.MinimumWidth = 6;
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.MinimumWidth = 6;
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            // 
            // clnEstado
            // 
            clnEstado.HeaderText = "Estado";
            clnEstado.MinimumWidth = 6;
            clnEstado.Name = "clnEstado";
            clnEstado.ReadOnly = true;
            // 
            // clnCep
            // 
            clnCep.HeaderText = "Cep";
            clnCep.MinimumWidth = 6;
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.MinimumWidth = 6;
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // FrmConsultaEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEndereco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultaEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmConsultaEndereco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvEndereco;
        private DataGridViewTextBoxColumn clnIdEndereço;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnEstado;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnComplemento;
    }
}