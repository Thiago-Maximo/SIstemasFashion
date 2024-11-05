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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnfecharForm = new Guna.UI2.WinForms.Guna2ControlBox();
            dgvConsultarFuncionario = new Guna.UI2.WinForms.Guna2DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnRg = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnData_Nasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            clnCargo = new DataGridViewTextBoxColumn();
            btnFechar = new Guna.UI2.WinForms.Guna2Button();
            lblPesquisa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtConsultar = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarFuncionario).BeginInit();
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
            btnfecharForm.Click += btnfecharForm_Click;
            // 
            // dgvConsultarFuncionario
            // 
            dgvConsultarFuncionario.AllowUserToAddRows = false;
            dgvConsultarFuncionario.AllowUserToDeleteRows = false;
            dgvConsultarFuncionario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvConsultarFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvConsultarFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultarFuncionario.ColumnHeadersHeight = 17;
            dgvConsultarFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvConsultarFuncionario.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnEmail, clnRg, clnCpf, clnData_Nasc, clnAtivo, clnCargo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvConsultarFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultarFuncionario.GridColor = Color.FromArgb(255, 192, 255);
            dgvConsultarFuncionario.Location = new Point(0, 116);
            dgvConsultarFuncionario.Name = "dgvConsultarFuncionario";
            dgvConsultarFuncionario.ReadOnly = true;
            dgvConsultarFuncionario.RowHeadersVisible = false;
            dgvConsultarFuncionario.Size = new Size(800, 281);
            dgvConsultarFuncionario.TabIndex = 25;
            dgvConsultarFuncionario.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvConsultarFuncionario.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvConsultarFuncionario.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvConsultarFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvConsultarFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvConsultarFuncionario.ThemeStyle.BackColor = Color.White;
            dgvConsultarFuncionario.ThemeStyle.GridColor = Color.FromArgb(255, 192, 255);
            dgvConsultarFuncionario.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvConsultarFuncionario.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvConsultarFuncionario.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvConsultarFuncionario.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvConsultarFuncionario.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvConsultarFuncionario.ThemeStyle.HeaderStyle.Height = 17;
            dgvConsultarFuncionario.ThemeStyle.ReadOnly = true;
            dgvConsultarFuncionario.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvConsultarFuncionario.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultarFuncionario.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvConsultarFuncionario.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvConsultarFuncionario.ThemeStyle.RowsStyle.Height = 25;
            dgvConsultarFuncionario.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvConsultarFuncionario.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            // clnRg
            // 
            clnRg.HeaderText = "RG";
            clnRg.Name = "clnRg";
            clnRg.ReadOnly = true;
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
            btnFechar.Click += btnFechar_Click;
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
            // txtConsultar
            // 
            txtConsultar.BackgroundImageLayout = ImageLayout.Zoom;
            txtConsultar.CustomizableEdges = customizableEdges5;
            txtConsultar.DefaultText = "";
            txtConsultar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConsultar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConsultar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConsultar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConsultar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConsultar.Font = new Font("Segoe UI", 9F);
            txtConsultar.ForeColor = Color.Black;
            txtConsultar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConsultar.IconLeft = Properties.Resources.pesquisa;
            txtConsultar.Location = new Point(24, 80);
            txtConsultar.Name = "txtConsultar";
            txtConsultar.PasswordChar = '\0';
            txtConsultar.PlaceholderText = "";
            txtConsultar.SelectedText = "";
            txtConsultar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtConsultar.Size = new Size(753, 30);
            txtConsultar.TabIndex = 35;
            txtConsultar.TextChanged += txtConsultar_TextChanged;
            // 
            // FrmConsultarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtConsultar);
            Controls.Add(lblPesquisa);
            Controls.Add(btnFechar);
            Controls.Add(dgvConsultarFuncionario);
            Controls.Add(btnfecharForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarCliente";
            Load += FrmConsultarFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnfecharForm;
        private Guna.UI2.WinForms.Guna2DataGridView dgvConsultarFuncionario;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPesquisa;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultar;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnRg;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnData_Nasc;
        private DataGridViewTextBoxColumn clnAtivo;
        private DataGridViewTextBoxColumn clnCargo;
    }
}