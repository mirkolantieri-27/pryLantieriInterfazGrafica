namespace pryLantieriInterfazGrafica
{
    partial class frmConversorUnidades
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
            lblValor = new Label();
            lblDesde = new Label();
            lblResultado = new Label();
            lblHacia = new Label();
            lblTitulo = new Label();
            btnConvertir = new Button();
            txtValor = new TextBox();
            cmoDesde = new ComboBox();
            cmoHacia = new ComboBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = Color.Transparent;
            lblValor.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold);
            lblValor.Location = new Point(93, 87);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(69, 27);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor:";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.BackColor = Color.Transparent;
            lblDesde.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold);
            lblDesde.Location = new Point(76, 134);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(82, 27);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold);
            lblResultado.Location = new Point(45, 270);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(120, 27);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado:";
            // 
            // lblHacia
            // 
            lblHacia.AutoSize = true;
            lblHacia.BackColor = Color.Transparent;
            lblHacia.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold);
            lblHacia.Location = new Point(82, 178);
            lblHacia.Name = "lblHacia";
            lblHacia.Size = new Size(76, 27);
            lblHacia.TabIndex = 3;
            lblHacia.Text = "Hacia:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(89, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(222, 42);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "CONVERSOR";
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir.Location = new Point(159, 217);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(121, 32);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "CONVERTIR";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(168, 81);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 33);
            txtValor.TabIndex = 6;
            // 
            // cmoDesde
            // 
            cmoDesde.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            cmoDesde.FormattingEnabled = true;
            cmoDesde.Items.AddRange(new object[] { "Milímetros", "Centímetros", "Metros", "Kilómetros", "Hectómetro" });
            cmoDesde.Location = new Point(159, 134);
            cmoDesde.Name = "cmoDesde";
            cmoDesde.Size = new Size(121, 27);
            cmoDesde.TabIndex = 7;
            cmoDesde.SelectedIndexChanged += cmoDesde_SelectedIndexChanged;
            // 
            // cmoHacia
            // 
            cmoHacia.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            cmoHacia.FormattingEnabled = true;
            cmoHacia.Items.AddRange(new object[] { "Milímetros", "Centímetros", "Metros", "Kilómetros", "Hectómetro" });
            cmoHacia.Location = new Point(159, 178);
            cmoHacia.Name = "cmoHacia";
            cmoHacia.Size = new Size(121, 27);
            cmoHacia.TabIndex = 8;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.White;
            txtResult.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(168, 264);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 33);
            txtResult.TabIndex = 9;
            // 
            // frmConversorUnidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(401, 358);
            Controls.Add(txtResult);
            Controls.Add(cmoHacia);
            Controls.Add(cmoDesde);
            Controls.Add(txtValor);
            Controls.Add(btnConvertir);
            Controls.Add(lblTitulo);
            Controls.Add(lblHacia);
            Controls.Add(lblResultado);
            Controls.Add(lblDesde);
            Controls.Add(lblValor);
            Name = "frmConversorUnidades";
            Text = "Caso 3 - Conversor de Unidades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private Label lblDesde;
        private Label lblResultado;
        private Label lblHacia;
        private Label lblTitulo;
        private Button btnConvertir;
        private TextBox txtValor;
        private ComboBox cmoDesde;
        private ComboBox cmoHacia;
        private TextBox txtResult;
    }
}