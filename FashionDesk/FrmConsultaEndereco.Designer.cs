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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvConsultarEndereco = new Guna.UI2.WinForms.Guna2DataGridView();
            clnIdEndereço = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnEstado = new DataGridViewTextBoxColumn();
            clnCep = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarEndereco).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultarEndereco
            // 
            dgvConsultarEndereco.AllowUserToAddRows = false;
            dgvConsultarEndereco.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvConsultarEndereco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvConsultarEndereco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvConsultarEndereco.ColumnHeadersHeight = 17;
            dgvConsultarEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvConsultarEndereco.Columns.AddRange(new DataGridViewColumn[] { clnIdEndereço, clnLogradouro, clnNumero, clnBairro, clnCidade, clnEstado, clnCep, clnComplemento });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvConsultarEndereco.DefaultCellStyle = dataGridViewCellStyle6;
            dgvConsultarEndereco.GridColor = Color.FromArgb(231, 229, 255);
            dgvConsultarEndereco.Location = new Point(30, 168);
            dgvConsultarEndereco.Name = "dgvConsultarEndereco";
            dgvConsultarEndereco.ReadOnly = true;
            dgvConsultarEndereco.RowHeadersVisible = false;
            dgvConsultarEndereco.RowHeadersWidth = 51;
            dgvConsultarEndereco.Size = new Size(746, 270);
            dgvConsultarEndereco.TabIndex = 7;
            dgvConsultarEndereco.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvConsultarEndereco.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvConsultarEndereco.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvConsultarEndereco.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvConsultarEndereco.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvConsultarEndereco.ThemeStyle.BackColor = Color.White;
            dgvConsultarEndereco.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvConsultarEndereco.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvConsultarEndereco.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvConsultarEndereco.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvConsultarEndereco.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvConsultarEndereco.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvConsultarEndereco.ThemeStyle.HeaderStyle.Height = 17;
            dgvConsultarEndereco.ThemeStyle.ReadOnly = true;
            dgvConsultarEndereco.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvConsultarEndereco.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultarEndereco.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvConsultarEndereco.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvConsultarEndereco.ThemeStyle.RowsStyle.Height = 25;
            dgvConsultarEndereco.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvConsultarEndereco.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvConsultarEndereco.CellContentDoubleClick += dgvEndereco_CellContentDoubleClick;
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
            Controls.Add(dgvConsultarEndereco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultaEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmConsultaEndereco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarEndereco).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvConsultarEndereco;
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