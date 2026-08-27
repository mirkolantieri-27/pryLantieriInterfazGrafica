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
            lblTitulo.Location = new Point(229, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(125, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label2";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(125, 121);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(38, 15);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "label3";
            lblTelefono.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(125, 178);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "button1";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(242, 178);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "button2";
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