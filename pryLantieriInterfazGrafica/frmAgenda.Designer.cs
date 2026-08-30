namespace pryLantieriInterfazGrafica
{
    partial class frmAgenda
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
            lblNombre = new Label();
            lblTelefono = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            lstContactos = new ListBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(174, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "AGENDA";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            lblNombre.Location = new Point(97, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(91, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            lblTelefono.Location = new Point(143, 116);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(45, 25);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Tel:";
            lblTelefono.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold);
            btnAgregar.Location = new Point(125, 168);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 43);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(257, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 43);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lstContactos
            // 
            lstContactos.FormattingEnabled = true;
            lstContactos.Location = new Point(125, 239);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(192, 64);
            lstContactos.TabIndex = 7;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 346);
            Controls.Add(lstContactos);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "frmAgenda";
            Text = "Caso 6 - Agenda de Contactos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblTelefono;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnAgregar;
        private Button btnEliminar;
        private ListBox lstContactos;
    }
}