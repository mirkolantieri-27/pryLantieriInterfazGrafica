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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtiquetas));
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
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Menu;
            lblTitulo.Location = new Point(136, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 43);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Presentación";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(97, 69);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(97, 104);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(79, 21);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.Transparent;
            lblEdad.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.ForeColor = Color.White;
            lblEdad.Location = new Point(120, 143);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(54, 21);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.Transparent;
            lblCarrera.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrera.ForeColor = Color.White;
            lblCarrera.Location = new Point(103, 176);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(71, 21);
            lblCarrera.TabIndex = 4;
            lblCarrera.Text = "Carrera:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            txtNombre.Location = new Point(180, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(136, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            txtApellido.Location = new Point(180, 101);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(136, 27);
            txtApellido.TabIndex = 2;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            txtEdad.Location = new Point(180, 137);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(27, 27);
            txtEdad.TabIndex = 3;
            txtEdad.TextChanged += txtEdad_TextChanged_1;
            // 
            // txtCarrera
            // 
            txtCarrera.Enabled = false;
            txtCarrera.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            txtCarrera.Location = new Point(180, 173);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(136, 27);
            txtCarrera.TabIndex = 4;
            txtCarrera.TextChanged += txtCarrera_TextChanged_1;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(12, 255);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 17);
            lblMensaje.TabIndex = 9;
            // 
            // btnPresentar
            // 
            btnPresentar.BackColor = Color.DarkSlateGray;
            btnPresentar.Enabled = false;
            btnPresentar.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPresentar.ForeColor = Color.White;
            btnPresentar.Location = new Point(191, 217);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(110, 36);
            btnPresentar.TabIndex = 10;
            btnPresentar.Text = "Presentar";
            btnPresentar.UseVisualStyleBackColor = false;
            btnPresentar.Click += btnPresentar_Click;
            // 
            // frmEtiquetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.fondo5;
            ClientSize = new Size(473, 313);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEtiquetas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caso 1 - Presentación Personal";
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