namespace FashionDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextCpf = new TextBox();
            TextName = new TextBox();
            btnInserir = new Button();
            btnAtualizar = new Button();
            btnCancelar = new Button();
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnData_Nasc = new DataGridViewTextBoxColumn();
            dateData_nasc = new DateTimePicker();
            textId = new TextBox();
            txtBusca = new TextBox();
            monthData = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // TextCpf
            // 
            TextCpf.Location = new Point(260, 30);
            TextCpf.Name = "TextCpf";
            TextCpf.Size = new Size(100, 23);
            TextCpf.TabIndex = 0;
            TextCpf.Text = "Cpf";
            // 
            // TextName
            // 
            TextName.Location = new Point(128, 30);
            TextName.Name = "TextName";
            TextName.Size = new Size(100, 23);
            TextName.TabIndex = 1;
            TextName.Text = "Nome";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(162, 239);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(254, 239);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(360, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnData_Nasc });
            dgvClientes.Location = new Point(96, 288);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(542, 150);
            dgvClientes.TabIndex = 8;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnData_Nasc
            // 
            clnData_Nasc.Frozen = true;
            clnData_Nasc.HeaderText = "Data_Nasc";
            clnData_Nasc.Name = "clnData_Nasc";
            clnData_Nasc.ReadOnly = true;
            // 
            // dateData_nasc
            // 
            dateData_nasc.Location = new Point(160, 73);
            dateData_nasc.Name = "dateData_nasc";
            dateData_nasc.Size = new Size(200, 23);
            dateData_nasc.TabIndex = 9;
            // 
            // textId
            // 
            textId.Location = new Point(22, 32);
            textId.Name = "textId";
            textId.Size = new Size(100, 23);
            textId.TabIndex = 10;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(590, 30);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(100, 23);
            txtBusca.TabIndex = 11;
            txtBusca.Text = "Busca";
            // 
            // monthData
            // 
            monthData.Enabled = false;
            monthData.Location = new Point(372, 65);
            monthData.Name = "monthData";
            monthData.TabIndex = 12;
            monthData.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthData);
            Controls.Add(txtBusca);
            Controls.Add(textId);
            Controls.Add(dateData_nasc);
            Controls.Add(dgvClientes);
            Controls.Add(btnCancelar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(TextName);
            Controls.Add(TextCpf);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextCpf;
        private TextBox TextName;
        private Button btnInserir;
        private Button btnAtualizar;
        private Button btnCancelar;
        private DataGridView dgvClientes;
        private DateTimePicker dateData_nasc;
        private TextBox textId;
        private TextBox txtBusca;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnData_Nasc;
        private MonthCalendar monthData;
    }
}
