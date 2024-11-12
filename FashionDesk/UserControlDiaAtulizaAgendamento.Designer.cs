namespace FashionDesk
{
    partial class UserControlDiaAtulizaAgendamento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblDays = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // lblDays
            // 
            lblDays.BackColor = Color.Transparent;
            lblDays.Font = new Font("Times New Roman", 20.25F, FontStyle.Italic);
            lblDays.Location = new Point(37, 12);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(31, 33);
            lblDays.TabIndex = 0;
            lblDays.Text = "00";
            lblDays.Click += lblDays_Click;
            // 
            // UserControlDiaAtulizaAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            Controls.Add(lblDays);
            Cursor = Cursors.Hand;
            Name = "UserControlDiaAtulizaAgendamento";
            Size = new Size(108, 59);
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblDays;
    }
}
