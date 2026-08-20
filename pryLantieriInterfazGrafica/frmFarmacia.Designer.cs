namespace pryLantieriInterfazGrafica
{
    partial class frmFarmacia
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
            lblCantidad = new Label();
            lblPersona = new Label();
            lblNombre = new Label();
            lblLab = new Label();
            lblPrecio = new Label();
            lblPrecioIva = new Label();
            btnAlmacenar = new Button();
            txtCantidad = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtPrecioIva = new TextBox();
            txtPersona = new TextBox();
            txtLab = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(73, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(410, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Productos de Farmacia";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblCantidad.Location = new Point(106, 78);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(80, 21);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad";
            lblCantidad.Click += this.lblCantidad_Click;
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblPersona.Location = new Point(321, 78);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(125, 21);
            lblPersona.TabIndex = 2;
            lblPersona.Text = "Quien Registra";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblNombre.Location = new Point(106, 143);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(72, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblLab
            // 
            lblLab.AutoSize = true;
            lblLab.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblLab.Location = new Point(336, 143);
            lblLab.Name = "lblLab";
            lblLab.Size = new Size(98, 21);
            lblLab.TabIndex = 4;
            lblLab.Text = "Laboratorio";
            lblLab.Click += lblLab_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblPrecio.Location = new Point(117, 208);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(59, 21);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += this.lblPrecio_Click;
            // 
            // lblPrecioIva
            // 
            lblPrecioIva.AutoSize = true;
            lblPrecioIva.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblPrecioIva.Location = new Point(326, 211);
            lblPrecioIva.Name = "lblPrecioIva";
            lblPrecioIva.Size = new Size(123, 21);
            lblPrecioIva.TabIndex = 6;
            lblPrecioIva.Text = "Precio con IVA";
            // 
            // btnAlmacenar
            // 
            btnAlmacenar.BackColor = Color.LightSeaGreen;
            btnAlmacenar.FlatStyle = FlatStyle.Flat;
            btnAlmacenar.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlmacenar.Location = new Point(187, 281);
            btnAlmacenar.Name = "btnAlmacenar";
            btnAlmacenar.Size = new Size(175, 43);
            btnAlmacenar.TabIndex = 7;
            btnAlmacenar.Text = "Almacenar";
            btnAlmacenar.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(96, 102);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 8;
            txtCantidad.TextChanged += this.textBox1_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 167);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(96, 232);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 10;
            txtPrecio.TextChanged += this.textBox3_TextChanged;
            // 
            // txtPrecioIva
            // 
            txtPrecioIva.Location = new Point(338, 232);
            txtPrecioIva.Name = "txtPrecioIva";
            txtPrecioIva.Size = new Size(100, 23);
            txtPrecioIva.TabIndex = 11;
            // 
            // txtPersona
            // 
            txtPersona.Location = new Point(338, 102);
            txtPersona.Name = "txtPersona";
            txtPersona.Size = new Size(100, 23);
            txtPersona.TabIndex = 12;
            // 
            // txtLab
            // 
            txtLab.Location = new Point(338, 167);
            txtLab.Name = "txtLab";
            txtLab.Size = new Size(100, 23);
            txtLab.TabIndex = 13;
            txtLab.TextChanged += this.textBox6_TextChanged;
            // 
            // frmFarmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(558, 393);
            Controls.Add(txtLab);
            Controls.Add(txtPersona);
            Controls.Add(txtPrecioIva);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCantidad);
            Controls.Add(btnAlmacenar);
            Controls.Add(lblPrecioIva);
            Controls.Add(lblPrecio);
            Controls.Add(lblLab);
            Controls.Add(lblNombre);
            Controls.Add(lblPersona);
            Controls.Add(lblCantidad);
            Controls.Add(lblTitulo);
            Name = "frmFarmacia";
            Text = "frmFarmacia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCantidad;
        private Label lblPersona;
        private Label lblNombre;
        private Label lblLab;
        private Label lblPrecio;
        private Label lblPrecioIva;
        private Button btnAlmacenar;
        private TextBox txtCantidad;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtPrecioIva;
        private TextBox txtPersona;
        private TextBox txtLab;
    }
}