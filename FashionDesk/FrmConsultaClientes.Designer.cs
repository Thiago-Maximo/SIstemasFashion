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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtConsultar = new Guna.UI2.WinForms.Guna2TextBox();
            lblPesquisa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnFechar = new Guna.UI2.WinForms.Guna2Button();
            btnfecharForm = new Guna.UI2.WinForms.Guna2ControlBox();
            dgvConsultarCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnRg = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnData_Nasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            clnCargo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCliente).BeginInit();
            SuspendLayout();
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
            txtConsultar.Location = new Point(27, 111);
            txtConsultar.Margin = new Padding(3, 5, 3, 5);
            txtConsultar.Name = "txtConsultar";
            txtConsultar.PasswordChar = '\0';
            txtConsultar.PlaceholderText = "";
            txtConsultar.SelectedText = "";
            txtConsultar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtConsultar.Size = new Size(861, 40);
            txtConsultar.TabIndex = 40;
            txtConsultar.TextChanged += txtConsultar_TextChanged;
            // 
            // lblPesquisa
            // 
            lblPesquisa.BackColor = Color.Transparent;
            lblPesquisa.Location = new Point(29, 88);
            lblPesquisa.Margin = new Padding(3, 4, 3, 4);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(65, 22);
            lblPesquisa.TabIndex = 39;
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
            btnFechar.Location = new Point(682, 541);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnFechar.Size = new Size(206, 56);
            btnFechar.TabIndex = 38;
            btnFechar.Text = "&Fechar";
            btnFechar.Click += btnFechar_Click;
            // 
            // btnfecharForm
            // 
            btnfecharForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnfecharForm.CustomizableEdges = customizableEdges11;
            btnfecharForm.FillColor = Color.FromArgb(139, 152, 166);
            btnfecharForm.IconColor = Color.White;
            btnfecharForm.Location = new Point(864, -1);
            btnfecharForm.Margin = new Padding(3, 4, 3, 4);
            btnfecharForm.Name = "btnfecharForm";
            btnfecharForm.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnfecharForm.Size = new Size(50, 32);
            btnfecharForm.TabIndex = 36;
            btnfecharForm.Click += btnfecharForm_Click;
            // 
            // dgvConsultarCliente
            // 
            dgvConsultarCliente.AllowUserToAddRows = false;
            dgvConsultarCliente.AllowUserToDeleteRows = false;
            dgvConsultarCliente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvConsultarCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvConsultarCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvConsultarCliente.ColumnHeadersHeight = 17;
            dgvConsultarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvConsultarCliente.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnEmail, clnRg, clnCpf, clnData_Nasc, clnAtivo, clnCargo });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvConsultarCliente.DefaultCellStyle = dataGridViewCellStyle6;
            dgvConsultarCliente.GridColor = Color.FromArgb(231, 229, 255);
            dgvConsultarCliente.Location = new Point(14, 175);
            dgvConsultarCliente.Margin = new Padding(3, 4, 3, 4);
            dgvConsultarCliente.Name = "dgvConsultarCliente";
            dgvConsultarCliente.ReadOnly = true;
            dgvConsultarCliente.RowHeadersVisible = false;
            dgvConsultarCliente.RowHeadersWidth = 51;
            dgvConsultarCliente.RowTemplate.Height = 25;
            dgvConsultarCliente.Size = new Size(887, 359);
            dgvConsultarCliente.TabIndex = 41;
            dgvConsultarCliente.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvConsultarCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvConsultarCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvConsultarCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvConsultarCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvConsultarCliente.ThemeStyle.BackColor = Color.White;
            dgvConsultarCliente.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvConsultarCliente.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvConsultarCliente.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvConsultarCliente.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvConsultarCliente.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvConsultarCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvConsultarCliente.ThemeStyle.HeaderStyle.Height = 17;
            dgvConsultarCliente.ThemeStyle.ReadOnly = true;
            dgvConsultarCliente.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvConsultarCliente.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultarCliente.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvConsultarCliente.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvConsultarCliente.ThemeStyle.RowsStyle.Height = 25;
            dgvConsultarCliente.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvConsultarCliente.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            // clnRg
            // 
            clnRg.FillWeight = 69.28934F;
            clnRg.HeaderText = "RG";
            clnRg.MinimumWidth = 6;
            clnRg.Name = "clnRg";
            clnRg.ReadOnly = true;
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
            // clnCargo
            // 
            clnCargo.FillWeight = 69.28934F;
            clnCargo.HeaderText = "Cargo";
            clnCargo.MinimumWidth = 6;
            clnCargo.Name = "clnCargo";
            clnCargo.ReadOnly = true;
            // 
            // FrmConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvConsultarCliente);
            Controls.Add(txtConsultar);
            Controls.Add(lblPesquisa);
            Controls.Add(btnFechar);
            Controls.Add(btnfecharForm);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConsultaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaClientes";
            Load += FrmConsultaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtConsultar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private Guna.UI2.WinForms.Guna2ControlBox btnfecharForm;
        private Guna.UI2.WinForms.Guna2DataGridView dgvConsultarCliente;
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