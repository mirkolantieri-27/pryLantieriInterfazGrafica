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
            lblMedicamento = new Label();
            lblLaboratorio = new Label();
            lblCodigo = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblTipo = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            txtMedicamento = new TextBox();
            txtLaboratorio = new TextBox();
            txtCodigo = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            cmoTipo = new ComboBox();
            lstMPS = new ListBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(46, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(301, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE FARMACIA";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblMedicamento.Location = new Point(46, 56);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(114, 19);
            lblMedicamento.TabIndex = 1;
            lblMedicamento.Text = "Medicamento:";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblLaboratorio.Location = new Point(61, 98);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(99, 19);
            lblLaboratorio.TabIndex = 2;
            lblLaboratorio.Text = "Laboratorio:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblCodigo.Location = new Point(95, 146);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(65, 19);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblPrecio.Location = new Point(100, 192);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 19);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblStock.Location = new Point(104, 236);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(56, 19);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblTipo.Location = new Point(114, 282);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(46, 19);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnAgregar.Location = new Point(24, 320);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 37);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnModificar.Location = new Point(144, 320);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 37);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnBorrar.Location = new Point(277, 320);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(96, 37);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(166, 56);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(100, 23);
            txtMedicamento.TabIndex = 10;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(166, 98);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(100, 23);
            txtLaboratorio.TabIndex = 11;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(166, 146);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(166, 192);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 13;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(166, 236);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 14;
            // 
            // cmoTipo
            // 
            cmoTipo.FormattingEnabled = true;
            cmoTipo.Location = new Point(166, 282);
            cmoTipo.Name = "cmoTipo";
            cmoTipo.Size = new Size(117, 23);
            cmoTipo.TabIndex = 15;
            // 
            // lstMPS
            // 
            lstMPS.FormattingEnabled = true;
            lstMPS.Location = new Point(24, 372);
            lstMPS.Name = "lstMPS";
            lstMPS.Size = new Size(349, 64);
            lstMPS.TabIndex = 16;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnBuscar.Location = new Point(24, 440);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(232, 37);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "BUSCAR MEDICAMENTO";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmFarmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 489);
            Controls.Add(btnBuscar);
            Controls.Add(lstMPS);
            Controls.Add(cmoTipo);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtCodigo);
            Controls.Add(txtLaboratorio);
            Controls.Add(txtMedicamento);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTipo);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblCodigo);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblMedicamento);
            Controls.Add(lblTitulo);
            Name = "frmFarmacia";
            Text = "Caso 9 - Farmacia y Medicamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMedicamento;
        private Label lblLaboratorio;
        private Label lblCodigo;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblTipo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private TextBox txtMedicamento;
        private TextBox txtLaboratorio;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private ComboBox cmoTipo;
        private ListBox lstMPS;
        private Button btnBuscar;
    }
}