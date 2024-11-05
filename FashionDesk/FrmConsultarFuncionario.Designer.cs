namespace FashionDesk
{
    partial class FrmConsultarFuncionario
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnfecharForm = new Guna.UI2.WinForms.Guna2ControlBox();
            dgvClientesInserir = new Guna.UI2.WinForms.Guna2DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnData_Nasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            clnCargo = new DataGridViewTextBoxColumn();
            btnFechar = new Guna.UI2.WinForms.Guna2Button();
            lblPesquisa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dgvClientesInserir).BeginInit();
            SuspendLayout();
            // 
            // btnfecharForm
            // 
            btnfecharForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnfecharForm.CustomizableEdges = customizableEdges1;
            btnfecharForm.FillColor = Color.FromArgb(139, 152, 166);
            btnfecharForm.IconColor = Color.White;
            btnfecharForm.Location = new Point(756, 0);
            btnfecharForm.Name = "btnfecharForm";
            btnfecharForm.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnfecharForm.Size = new Size(44, 24);
            btnfecharForm.TabIndex = 14;
            // 
            // dgvClientesInserir
            // 
            dgvClientesInserir.AllowUserToAddRows = false;
            dgvClientesInserir.AllowUserToDeleteRows = false;
            dgvClientesInserir.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvClientesInserir.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientesInserir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientesInserir.ColumnHeadersHeight = 17;
            dgvClientesInserir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClientesInserir.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnEmail, clnCpf, clnData_Nasc, clnAtivo, clnCargo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientesInserir.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientesInserir.GridColor = Color.FromArgb(255, 192, 255);
            dgvClientesInserir.Location = new Point(0, 116);
            dgvClientesInserir.Name = "dgvClientesInserir";
            dgvClientesInserir.ReadOnly = true;
            dgvClientesInserir.RowHeadersVisible = false;
            dgvClientesInserir.Size = new Size(800, 281);
            dgvClientesInserir.TabIndex = 25;
            dgvClientesInserir.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvClientesInserir.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvClientesInserir.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvClientesInserir.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvClientesInserir.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvClientesInserir.ThemeStyle.BackColor = Color.White;
            dgvClientesInserir.ThemeStyle.GridColor = Color.FromArgb(255, 192, 255);
            dgvClientesInserir.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvClientesInserir.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientesInserir.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvClientesInserir.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvClientesInserir.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClientesInserir.ThemeStyle.HeaderStyle.Height = 17;
            dgvClientesInserir.ThemeStyle.ReadOnly = true;
            dgvClientesInserir.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvClientesInserir.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientesInserir.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvClientesInserir.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvClientesInserir.ThemeStyle.RowsStyle.Height = 25;
            dgvClientesInserir.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvClientesInserir.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // clnID
            // 
            clnID.FillWeight = 69.28934F;
            clnID.HeaderText = "Id";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.FillWeight = 69.28934F;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnCpf
            // 
            clnCpf.FillWeight = 69.28934F;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnData_Nasc
            // 
            clnData_Nasc.HeaderText = "Data de Nascimento";
            clnData_Nasc.Name = "clnData_Nasc";
            clnData_Nasc.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.FillWeight = 69.28934F;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // clnCargo
            // 
            clnCargo.HeaderText = "Cargo";
            clnCargo.Name = "clnCargo";
            clnCargo.ReadOnly = true;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.BorderRadius = 10;
            btnFechar.CustomizableEdges = customizableEdges3;
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.White;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.Black;
            btnFechar.HoverState.FillColor = Color.FromArgb(255, 192, 255);
            btnFechar.Location = new Point(597, 403);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFechar.Size = new Size(180, 42);
            btnFechar.TabIndex = 32;
            btnFechar.Text = "&Fechar";
            // 
            // lblPesquisa
            // 
            lblPesquisa.BackColor = Color.Transparent;
            lblPesquisa.Location = new Point(25, 63);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(53, 17);
            lblPesquisa.TabIndex = 34;
            lblPesquisa.Text = "Pesquisar";
            // 
            // FrmConsultarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPesquisa);
            Controls.Add(btnFechar);
            Controls.Add(dgvClientesInserir);
            Controls.Add(btnfecharForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientesInserir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnfecharForm;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientesInserir;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPesquisa;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnData_Nasc;
        private DataGridViewTextBoxColumn clnAtivo;
        private DataGridViewTextBoxColumn clnCargo;
    }
}