namespace FashionDesk
{
    partial class FrmSelecionarFuncionario
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtConsultar = new Guna.UI2.WinForms.Guna2TextBox();
            lblPesquisa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnFechar = new Guna.UI2.WinForms.Guna2Button();
            dgvSelecionarFuncionario = new Guna.UI2.WinForms.Guna2DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnRg = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnData_Nasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            clnCargo = new DataGridViewTextBoxColumn();
            btnfecharForm = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)dgvSelecionarFuncionario).BeginInit();
            SuspendLayout();
            // 
            // txtConsultar
            // 
            txtConsultar.BackgroundImageLayout = ImageLayout.Zoom;
            txtConsultar.CustomizableEdges = customizableEdges1;
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
            txtConsultar.Location = new Point(11, 41);
            txtConsultar.Name = "txtConsultar";
            txtConsultar.PasswordChar = '\0';
            txtConsultar.PlaceholderText = "";
            txtConsultar.SelectedText = "";
            txtConsultar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtConsultar.Size = new Size(753, 30);
            txtConsultar.TabIndex = 40;
            // 
            // lblPesquisa
            // 
            lblPesquisa.BackColor = Color.Transparent;
            lblPesquisa.Location = new Point(17, 24);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(53, 17);
            lblPesquisa.TabIndex = 39;
            lblPesquisa.Text = "Pesquisar";
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
            btnFechar.Location = new Point(587, 364);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFechar.Size = new Size(180, 42);
            btnFechar.TabIndex = 38;
            btnFechar.Text = "&Fechar";
            // 
            // dgvSelecionarFuncionario
            // 
            dgvSelecionarFuncionario.AllowUserToAddRows = false;
            dgvSelecionarFuncionario.AllowUserToDeleteRows = false;
            dgvSelecionarFuncionario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvSelecionarFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSelecionarFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSelecionarFuncionario.ColumnHeadersHeight = 17;
            dgvSelecionarFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSelecionarFuncionario.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnEmail, clnRg, clnCpf, clnData_Nasc, clnAtivo, clnCargo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSelecionarFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSelecionarFuncionario.GridColor = Color.FromArgb(255, 192, 255);
            dgvSelecionarFuncionario.Location = new Point(12, 77);
            dgvSelecionarFuncionario.Name = "dgvSelecionarFuncionario";
            dgvSelecionarFuncionario.ReadOnly = true;
            dgvSelecionarFuncionario.RowHeadersVisible = false;
            dgvSelecionarFuncionario.Size = new Size(755, 281);
            dgvSelecionarFuncionario.TabIndex = 37;
            dgvSelecionarFuncionario.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvSelecionarFuncionario.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvSelecionarFuncionario.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvSelecionarFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvSelecionarFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvSelecionarFuncionario.ThemeStyle.BackColor = Color.White;
            dgvSelecionarFuncionario.ThemeStyle.GridColor = Color.FromArgb(255, 192, 255);
            dgvSelecionarFuncionario.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvSelecionarFuncionario.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSelecionarFuncionario.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvSelecionarFuncionario.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvSelecionarFuncionario.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSelecionarFuncionario.ThemeStyle.HeaderStyle.Height = 17;
            dgvSelecionarFuncionario.ThemeStyle.ReadOnly = true;
            dgvSelecionarFuncionario.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvSelecionarFuncionario.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSelecionarFuncionario.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvSelecionarFuncionario.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvSelecionarFuncionario.ThemeStyle.RowsStyle.Height = 25;
            dgvSelecionarFuncionario.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvSelecionarFuncionario.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvSelecionarFuncionario.CellContentClick += dgvSelecionarFuncionario_CellContentClick;
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
            // btnfecharForm
            // 
            btnfecharForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnfecharForm.CustomizableEdges = customizableEdges5;
            btnfecharForm.FillColor = Color.FromArgb(139, 152, 166);
            btnfecharForm.IconColor = Color.White;
            btnfecharForm.Location = new Point(740, -1);
            btnfecharForm.Name = "btnfecharForm";
            btnfecharForm.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnfecharForm.Size = new Size(44, 24);
            btnfecharForm.TabIndex = 36;
            // 
            // FrmSelecionarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(txtConsultar);
            Controls.Add(lblPesquisa);
            Controls.Add(btnFechar);
            Controls.Add(dgvSelecionarFuncionario);
            Controls.Add(btnfecharForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSelecionarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSelecionarFuncionario";
            ((System.ComponentModel.ISupportInitialize)dgvSelecionarFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtConsultar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSelecionarFuncionario;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnRg;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnData_Nasc;
        private DataGridViewTextBoxColumn clnAtivo;
        private DataGridViewTextBoxColumn clnCargo;
        private Guna.UI2.WinForms.Guna2ControlBox btnfecharForm;
    }
}