namespace FashionDesk
{
    partial class FrmConsultaClientes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtConsultar = new Guna.UI2.WinForms.Guna2TextBox();
            lblPesquisa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnFechar = new Guna.UI2.WinForms.Guna2Button();
            btnfecharForm = new Guna.UI2.WinForms.Guna2ControlBox();
            dgvFuncionariosAtualizar = new Guna.UI2.WinForms.Guna2DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnRg = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnData_Nasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            clnCargo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionariosAtualizar).BeginInit();
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
            txtConsultar.Location = new Point(24, 83);
            txtConsultar.Name = "txtConsultar";
            txtConsultar.PasswordChar = '\0';
            txtConsultar.PlaceholderText = "";
            txtConsultar.SelectedText = "";
            txtConsultar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtConsultar.Size = new Size(753, 30);
            txtConsultar.TabIndex = 40;
            txtConsultar.TextChanged += txtConsultar_TextChanged;
            // 
            // lblPesquisa
            // 
            lblPesquisa.BackColor = Color.Transparent;
            lblPesquisa.Location = new Point(25, 66);
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
            btnFechar.Location = new Point(597, 406);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFechar.Size = new Size(180, 42);
            btnFechar.TabIndex = 38;
            btnFechar.Text = "&Fechar";
            btnFechar.Click += btnFechar_Click;
            // 
            // btnfecharForm
            // 
            btnfecharForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnfecharForm.CustomizableEdges = customizableEdges5;
            btnfecharForm.FillColor = Color.FromArgb(139, 152, 166);
            btnfecharForm.IconColor = Color.White;
            btnfecharForm.Location = new Point(756, -1);
            btnfecharForm.Name = "btnfecharForm";
            btnfecharForm.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnfecharForm.Size = new Size(44, 24);
            btnfecharForm.TabIndex = 36;
            btnfecharForm.Click += btnfecharForm_Click;
            // 
            // dgvFuncionariosAtualizar
            // 
            dgvFuncionariosAtualizar.AllowUserToAddRows = false;
            dgvFuncionariosAtualizar.AllowUserToDeleteRows = false;
            dgvFuncionariosAtualizar.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvFuncionariosAtualizar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFuncionariosAtualizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFuncionariosAtualizar.ColumnHeadersHeight = 17;
            dgvFuncionariosAtualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvFuncionariosAtualizar.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnEmail, clnRg, clnCpf, clnData_Nasc, clnAtivo, clnCargo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvFuncionariosAtualizar.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFuncionariosAtualizar.GridColor = Color.FromArgb(231, 229, 255);
            dgvFuncionariosAtualizar.Location = new Point(12, 131);
            dgvFuncionariosAtualizar.Name = "dgvFuncionariosAtualizar";
            dgvFuncionariosAtualizar.ReadOnly = true;
            dgvFuncionariosAtualizar.RowHeadersVisible = false;
            dgvFuncionariosAtualizar.Size = new Size(776, 269);
            dgvFuncionariosAtualizar.TabIndex = 41;
            dgvFuncionariosAtualizar.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvFuncionariosAtualizar.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvFuncionariosAtualizar.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvFuncionariosAtualizar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvFuncionariosAtualizar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvFuncionariosAtualizar.ThemeStyle.BackColor = Color.White;
            dgvFuncionariosAtualizar.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvFuncionariosAtualizar.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvFuncionariosAtualizar.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFuncionariosAtualizar.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvFuncionariosAtualizar.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvFuncionariosAtualizar.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvFuncionariosAtualizar.ThemeStyle.HeaderStyle.Height = 17;
            dgvFuncionariosAtualizar.ThemeStyle.ReadOnly = true;
            dgvFuncionariosAtualizar.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvFuncionariosAtualizar.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFuncionariosAtualizar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvFuncionariosAtualizar.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvFuncionariosAtualizar.ThemeStyle.RowsStyle.Height = 25;
            dgvFuncionariosAtualizar.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvFuncionariosAtualizar.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            clnRg.FillWeight = 69.28934F;
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
            clnCargo.FillWeight = 69.28934F;
            clnCargo.HeaderText = "Cargo";
            clnCargo.Name = "clnCargo";
            clnCargo.ReadOnly = true;
            // 
            // FrmConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvFuncionariosAtualizar);
            Controls.Add(txtConsultar);
            Controls.Add(lblPesquisa);
            Controls.Add(btnFechar);
            Controls.Add(btnfecharForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaClientes";
            Load += FrmConsultaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionariosAtualizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtConsultar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private Guna.UI2.WinForms.Guna2ControlBox btnfecharForm;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFuncionariosAtualizar;
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