namespace pryLantieriInterfazGrafica
{
    partial class frmCalculadoraBasica
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
            lblTitulo = new Label();
            lblNum1 = new Label();
            lbNum2 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(114, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "C A S I O";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblNum1.Location = new Point(73, 88);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(86, 19);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Número 1:";
            // 
            // lbNum2
            // 
            lbNum2.AutoSize = true;
            lbNum2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lbNum2.Location = new Point(73, 127);
            lbNum2.Name = "lbNum2";
            lbNum2.Size = new Size(86, 19);
            lbNum2.TabIndex = 2;
            lbNum2.Text = "Número 2:";
            // 
            // frmCalculadoraBasica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 314);
            Controls.Add(lbNum2);
            Controls.Add(lblNum1);
            Controls.Add(lblTitulo);
            Name = "frmCalculadoraBasica";
            Text = "frmCalculadoraBasica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNum1;
        private Label lbNum2;
    }
}