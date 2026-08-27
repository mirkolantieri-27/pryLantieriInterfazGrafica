namespace pryLantieriInterfazGrafica
{
    partial class frmLogin
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
            lblUsuario = new Label();
            lblClave = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIngresar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(103, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(141, 47);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "LOGIN";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(12, 91);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(123, 37);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.BackColor = Color.Transparent;
            lblClave.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold);
            lblClave.ForeColor = Color.White;
            lblClave.Location = new Point(23, 145);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(96, 37);
            lblClave.TabIndex = 2;
            lblClave.Text = "Clave:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            txtUsuario.Location = new Point(144, 95);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 33);
            txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            txtClave.Location = new Point(144, 149);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 33);
            txtClave.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(104, 214);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(140, 35);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(76, 313);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(17, 15);
            lblMensaje.TabIndex = 6;
            lblMensaje.Text = "\"\"";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(346, 385);
            Controls.Add(lblMensaje);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Name = "frmLogin";
            Text = "Caso 5 - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIngresar;
        private Label lblMensaje;
    }
}