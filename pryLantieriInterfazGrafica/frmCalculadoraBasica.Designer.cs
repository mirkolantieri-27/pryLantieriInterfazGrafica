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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraBasica));
            lblTitulo = new Label();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblResultado = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicar = new Button();
            btnDivision = new Button();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(93, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(291, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CALCULADORA";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            lblNum1.Location = new Point(76, 76);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(107, 25);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Número 1:";
           
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            lblNum2.Location = new Point(76, 121);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(107, 25);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Número 2:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            lblResultado.Location = new Point(76, 225);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(110, 25);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnSuma.Location = new Point(118, 167);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(48, 38);
            btnSuma.TabIndex = 4;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnResta.Location = new Point(189, 167);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(48, 38);
            btnResta.TabIndex = 5;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnMultiplicar.Location = new Point(253, 167);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(48, 38);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnDivision.Location = new Point(321, 167);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(48, 38);
            btnDivision.TabIndex = 7;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // txtN1
            // 
            txtN1.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            txtN1.Location = new Point(189, 76);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 32);
            txtN1.TabIndex = 8;
            txtN1.TextChanged += txtN1_TextChanged;
            // 
            // txtN2
            // 
            txtN2.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            txtN2.Location = new Point(189, 121);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 32);
            txtN2.TabIndex = 9;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            txtResult.Location = new Point(189, 225);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 32);
            txtResult.TabIndex = 10;
            // 
            // frmCalculadoraBasica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(463, 300);
            Controls.Add(txtResult);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(lblResultado);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCalculadoraBasica";
            Text = "Caso 2 - Calculadora Básica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicar;
        private Button btnDivision;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtResult;
    }
}