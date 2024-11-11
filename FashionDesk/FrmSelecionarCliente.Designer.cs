namespace FashionDesk
{
    partial class FrmSelecionarCliente
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvSelecionarCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnData_Nasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            txtConsultar = new Guna.UI2.WinForms.Guna2TextBox();
            lblPesquisa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnFechar = new Guna.UI2.WinForms.Guna2Button();
            btnfecharForm = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)dgvSelecionarCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvSelecionarCliente
            // 
            dgvSelecionarCliente.AllowUserToAddRows = false;
            dgvSelecionarCliente.AllowUserToDeleteRows = false;
            dgvSelecionarCliente.AllowUserToOrderColumns = true;
            dgvSelecionarCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(253, 187, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvSelecionarCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(253, 187, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(253, 187, 255);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvSelecionarCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvSelecionarCliente.ColumnHeadersHeight = 17;
            dgvSelecionarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSelecionarCliente.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnEmail, clnCpf, clnData_Nasc, clnAtivo });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvSelecionarCliente.DefaultCellStyle = dataGridViewCellStyle7;
            dgvSelecionarCliente.GridColor = Color.FromArgb(255, 192, 255);
            dgvSelecionarCliente.Location = new Point(13, 94);
            dgvSelecionarCliente.Name = "dgvSelecionarCliente";
            dgvSelecionarCliente.ReadOnly = true;
            dgvSelecionarCliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvSelecionarCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvSelecionarCliente.RowHeadersVisible = false;
            dgvSelecionarCliente.RowHeadersWidth = 51;
            dgvSelecionarCliente.Size = new Size(752, 269);
            dgvSelecionarCliente.TabIndex = 46;
            dgvSelecionarCliente.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvSelecionarCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvSelecionarCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvSelecionarCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvSelecionarCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvSelecionarCliente.ThemeStyle.BackColor = Color.White;
            dgvSelecionarCliente.ThemeStyle.GridColor = Color.FromArgb(255, 192, 255);
            dgvSelecionarCliente.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvSelecionarCliente.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSelecionarCliente.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvSelecionarCliente.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvSelecionarCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSelecionarCliente.ThemeStyle.HeaderStyle.Height = 17;
            dgvSelecionarCliente.ThemeStyle.ReadOnly = true;
            dgvSelecionarCliente.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvSelecionarCliente.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSelecionarCliente.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvSelecionarCliente.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvSelecionarCliente.ThemeStyle.RowsStyle.Height = 25;
            dgvSelecionarCliente.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvSelecionarCliente.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvSelecionarCliente.CellContentClick += dgvConsultarCliente_CellContentClick;
            // 
            // clnID
            // 
            clnID.FillWeight = 69.28934F;
            clnID.HeaderText = "Id";
            clnID.MinimumWidth = 6;
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.FillWeight = 69.28934F;
            clnNome.HeaderText = "Nome";
            clnNome.MinimumWidth = 6;
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.MinimumWidth = 6;
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnCpf
            // 
            clnCpf.FillWeight = 69.28934F;
            clnCpf.HeaderText = "CPF";
            clnCpf.MinimumWidth = 6;
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnData_Nasc
            // 
            clnData_Nasc.HeaderText = "Data de Nascimento";
            clnData_Nasc.MinimumWidth = 6;
            clnData_Nasc.Name = "clnData_Nasc";
            clnData_Nasc.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.FillWeight = 69.28934F;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.MinimumWidth = 6;
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // txtConsultar
            // 
            txtConsultar.BackgroundImageLayout = ImageLayout.Zoom;
            txtConsultar.CustomizableEdges = customizableEdges7;
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
            txtConsultar.Location = new Point(12, 48);
            txtConsultar.Margin = new Padding(3, 4, 3, 4);
            txtConsultar.Name = "txtConsultar";
            txtConsultar.PasswordChar = '\0';
            txtConsultar.PlaceholderText = "";
            txtConsultar.SelectedText = "";
            txtConsultar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtConsultar.Size = new Size(753, 30);
            txtConsultar.TabIndex = 45;
            txtConsultar.TextChanged += txtConsultar_TextChanged;
            // 
            // lblPesquisa
            // 
            lblPesquisa.BackColor = Color.Transparent;
            lblPesquisa.Location = new Point(13, 31);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(53, 17);
            lblPesquisa.TabIndex = 44;
            lblPesquisa.Text = "Pesquisar";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.BorderRadius = 10;
            btnFechar.CustomizableEdges = customizableEdges9;
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.White;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.Black;
            btnFechar.HoverState.FillColor = Color.FromArgb(255, 192, 255);
            btnFechar.Location = new Point(585, 369);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnFechar.Size = new Size(180, 42);
            btnFechar.TabIndex = 43;
            btnFechar.Text = "&Fechar";
            btnFechar.Click += btnFechar_Click;
            // 
            // btnfecharForm
            // 
            btnfecharForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnfecharForm.CustomizableEdges = customizableEdges11;
            btnfecharForm.FillColor = Color.FromArgb(139, 152, 166);
            btnfecharForm.IconColor = Color.White;
            btnfecharForm.Location = new Point(743, -2);
            btnfecharForm.Name = "btnfecharForm";
            btnfecharForm.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnfecharForm.Size = new Size(44, 24);
            btnfecharForm.TabIndex = 42;
            // 
            // FrmSelecionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(dgvSelecionarCliente);
            Controls.Add(txtConsultar);
            Controls.Add(lblPesquisa);
            Controls.Add(btnFechar);
            Controls.Add(btnfecharForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSelecionarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSelecionarCliente";
            Load += FrmSelecionarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSelecionarCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvSelecionarCliente;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnData_Nasc;
        private DataGridViewTextBoxColumn clnAtivo;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private Guna.UI2.WinForms.Guna2ControlBox btnfecharForm;
    }
}