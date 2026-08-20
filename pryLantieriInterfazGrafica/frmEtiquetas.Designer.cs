namespace pryLantieriInterfazGrafica
{
    partial class frmEtiquetas
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
            lblApellido = new Label();
            lblEdad = new Label();
            lblCarrera = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtCarrera = new TextBox();
            lblMensaje = new Label();
            btnPresentar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(156, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(146, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Presentación";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(66, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(66, 84);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(79, 21);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(89, 123);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(54, 21);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrera.Location = new Point(72, 156);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(71, 21);
            lblCarrera.TabIndex = 4;
            lblCarrera.Text = "Carrera:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            txtNombre.Location = new Point(166, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(136, 27);
            txtNombre.TabIndex = 5;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            txtApellido.Location = new Point(166, 85);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(136, 27);
            txtApellido.TabIndex = 6;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            txtEdad.Location = new Point(166, 121);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(27, 27);
            txtEdad.TabIndex = 7;
            txtEdad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCarrera
            // 
            txtCarrera.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            txtCarrera.Location = new Point(166, 157);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(136, 27);
            txtCarrera.TabIndex = 8;
            txtCarrera.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(12, 255);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 17);
            lblMensaje.TabIndex = 9;
            // 
            // btnPresentar
            // 
            btnPresentar.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPresentar.Location = new Point(177, 201);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(110, 36);
            btnPresentar.TabIndex = 10;
            btnPresentar.Text = "Presentar";
            btnPresentar.UseVisualStyleBackColor = true;
            btnPresentar.Click += btnPresentar_Click_1;
            // 
            // frmEtiquetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 313);
            Controls.Add(btnPresentar);
            Controls.Add(lblMensaje);
            Controls.Add(txtCarrera);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "frmEtiquetas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Interfaz Gráfica - Etiquetas/Label";
            Load += frmEtiquetas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblCarrera;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtCarrera;
        private Label lblMensaje;
        private Button btnPresentar;
    }
}