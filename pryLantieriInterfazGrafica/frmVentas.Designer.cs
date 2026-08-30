namespace pryLantieriInterfazGrafica
{
    partial class frmVentas
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
            lblProducto = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            btnAgregar = new Button();
            lblTotal = new Label();
            lstProductos = new ListBox();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(58, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(359, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE VENTAS";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblProducto.Location = new Point(58, 72);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(85, 21);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblPrecio.Location = new Point(58, 116);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 21);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblCantidad.Location = new Point(58, 164);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(85, 21);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(164, 217);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 35);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(58, 353);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(69, 21);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "TOTAL:";
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.Location = new Point(101, 267);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(243, 64);
            lstProductos.TabIndex = 6;
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProducto.Location = new Point(175, 69);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 33);
            txtProducto.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(175, 116);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 33);
            txtPrecio.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(175, 167);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 33);
            txtCantidad.TabIndex = 9;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 408);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(lstProductos);
            Controls.Add(lblTotal);
            Controls.Add(btnAgregar);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblProducto);
            Controls.Add(lblTitulo);
            Name = "frmVentas";
            Text = "Caso 7 - Sistema de Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblProducto;
        private Label lblPrecio;
        private Label lblCantidad;
        private Button btnAgregar;
        private Label lblTotal;
        private ListBox lstProductos;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
    }
}