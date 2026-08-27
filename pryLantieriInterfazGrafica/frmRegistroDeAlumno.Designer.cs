namespace pryLantieriInterfazGrafica
{
    partial class frmRegistroDeAlumno
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
            lblDni = new Label();
            lblSexo = new Label();
            lblTurno = new Label();
            lblCarrera = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnRegistro = new Button();
            txtDni = new TextBox();
            rdoMasculino = new RadioButton();
            rdoFemenino = new RadioButton();
            choMañana = new CheckBox();
            choTarde = new CheckBox();
            choNoche = new CheckBox();
            cmoCarrera = new ComboBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(45, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(393, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE ALUMNO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblNombre.Location = new Point(120, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblApellido.Location = new Point(121, 110);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 19);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblDni.Location = new Point(150, 147);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 19);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblSexo.Location = new Point(143, 197);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(50, 19);
            lblSexo.TabIndex = 4;
            lblSexo.Text = "Sexo:";
            //lblSexo.Click += this.lblSexo_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblTurno.Location = new Point(138, 237);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(55, 19);
            lblTurno.TabIndex = 5;
            lblTurno.Text = "Turno:";
            //lblTurno.Click += this.lblTurno_Click;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            lblCarrera.Location = new Point(123, 288);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(70, 19);
            lblCarrera.TabIndex = 6;
            lblCarrera.Text = "Carrera:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            txtNombre.Location = new Point(199, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 32);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            txtApellido.Location = new Point(199, 106);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 32);
            txtApellido.TabIndex = 8;
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(187, 329);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(142, 41);
            btnRegistro.TabIndex = 9;
            btnRegistro.Text = "REGISTRAR";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            txtDni.Location = new Point(199, 144);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 32);
            txtDni.TabIndex = 10;
            // 
            // rdoMasculino
            // 
            rdoMasculino.AutoSize = true;
            rdoMasculino.Location = new Point(199, 198);
            rdoMasculino.Name = "rdoMasculino";
            rdoMasculino.Size = new Size(80, 19);
            rdoMasculino.TabIndex = 11;
            rdoMasculino.TabStop = true;
            rdoMasculino.Text = "Masculino";
            rdoMasculino.UseVisualStyleBackColor = true;
            //rdoMasculino.CheckedChanged += this.rdoMasculino_CheckedChanged;
            // 
            // rdoFemenino
            // 
            rdoFemenino.AutoSize = true;
            rdoFemenino.Location = new Point(285, 198);
            rdoFemenino.Name = "rdoFemenino";
            rdoFemenino.Size = new Size(78, 19);
            rdoFemenino.TabIndex = 12;
            rdoFemenino.TabStop = true;
            rdoFemenino.Text = "Femenino";
            rdoFemenino.UseVisualStyleBackColor = true;
            //rdoFemenino.CheckedChanged += this.rdoFemenino_CheckedChanged;
            // 
            // choMañana
            // 
            choMañana.AutoSize = true;
            choMañana.Location = new Point(199, 239);
            choMañana.Name = "choMañana";
            choMañana.Size = new Size(69, 19);
            choMañana.TabIndex = 13;
            choMañana.Text = "Mañana";
            choMañana.UseVisualStyleBackColor = true;
            //choMañana.CheckedChanged += this.choMañana_CheckedChanged;
            // 
            // choTarde
            // 
            choTarde.AutoSize = true;
            choTarde.Location = new Point(285, 239);
            choTarde.Name = "choTarde";
            choTarde.Size = new Size(55, 19);
            choTarde.TabIndex = 14;
            choTarde.Text = "Tarde";
            choTarde.UseVisualStyleBackColor = true;
            //choTarde.CheckedChanged += this.choTarde_CheckedChanged;
            // 
            // choNoche
            // 
            choNoche.AutoSize = true;
            choNoche.Location = new Point(360, 239);
            choNoche.Name = "choNoche";
            choNoche.Size = new Size(61, 19);
            choNoche.TabIndex = 15;
            choNoche.Text = "Noche";
            choNoche.UseVisualStyleBackColor = true;
            choNoche.CheckedChanged += choNoche_CheckedChanged;
            // 
            // cmoCarrera
            // 
            cmoCarrera.FormattingEnabled = true;
            cmoCarrera.Location = new Point(199, 284);
            cmoCarrera.Name = "cmoCarrera";
            cmoCarrera.Size = new Size(121, 23);
            cmoCarrera.TabIndex = 16;
            // 
            // frmRegistroDeAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 396);
            Controls.Add(cmoCarrera);
            Controls.Add(choNoche);
            Controls.Add(choTarde);
            Controls.Add(choMañana);
            Controls.Add(rdoFemenino);
            Controls.Add(rdoMasculino);
            Controls.Add(txtDni);
            Controls.Add(btnRegistro);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblCarrera);
            Controls.Add(lblTurno);
            Controls.Add(lblSexo);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "frmRegistroDeAlumno";
            Text = "Caso 4 - Registro de Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblSexo;
        private Label lblTurno;
        private Label lblCarrera;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnRegistro;
        private TextBox txtDni;
        private RadioButton rdoMasculino;
        private RadioButton rdoFemenino;
        private CheckBox choMañana;
        private CheckBox choTarde;
        private CheckBox choNoche;
        private ComboBox cmoCarrera;
    }
}