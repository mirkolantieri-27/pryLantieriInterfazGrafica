namespace pryLantieriInterfazGrafica
{
    partial class frmGestorTareas
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
            lblTarea = new Label();
            lblPrioridad = new Label();
            lblFecha = new Label();
            txtTarea = new TextBox();
            cmoPrioridad = new ComboBox();
            txtFecha = new TextBox();
            btnAgregar = new Button();
            lstTareas = new ListBox();
            btnEliminar = new Button();
            btnCompletar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(108, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(216, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MIS TAREAS";
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblTarea.Location = new Point(111, 68);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(57, 21);
            lblTarea.TabIndex = 1;
            lblTarea.Text = "Tarea:";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblPrioridad.Location = new Point(82, 114);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(86, 21);
            lblPrioridad.TabIndex = 2;
            lblPrioridad.Text = "Prioridad:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblFecha.Location = new Point(107, 170);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(61, 21);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(174, 68);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(100, 23);
            txtTarea.TabIndex = 4;
            // 
            // cmoPrioridad
            // 
            cmoPrioridad.FormattingEnabled = true;
            cmoPrioridad.Location = new Point(174, 115);
            cmoPrioridad.Name = "cmoPrioridad";
            cmoPrioridad.Size = new Size(100, 23);
            cmoPrioridad.TabIndex = 5;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(174, 171);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(81, 219);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 41);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AGREGAR TAREA";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.Location = new Point(81, 279);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(262, 64);
            lstTareas.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            btnEliminar.Location = new Point(81, 358);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 39);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCompletar
            // 
            btnCompletar.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold);
            btnCompletar.Location = new Point(227, 358);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(116, 39);
            btnCompletar.TabIndex = 10;
            btnCompletar.Text = "COMPLETAR";
            btnCompletar.UseVisualStyleBackColor = true;
            // 
            // frmGestorTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 424);
            Controls.Add(btnCompletar);
            Controls.Add(btnEliminar);
            Controls.Add(lstTareas);
            Controls.Add(btnAgregar);
            Controls.Add(txtFecha);
            Controls.Add(cmoPrioridad);
            Controls.Add(txtTarea);
            Controls.Add(lblFecha);
            Controls.Add(lblPrioridad);
            Controls.Add(lblTarea);
            Controls.Add(lblTitulo);
            Name = "frmGestorTareas";
            Text = "Caso 8 - Gestor de Tareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTarea;
        private Label lblPrioridad;
        private Label lblFecha;
        private TextBox txtTarea;
        private ComboBox cmoPrioridad;
        private TextBox txtFecha;
        private Button btnAgregar;
        private ListBox lstTareas;
        private Button btnEliminar;
        private Button btnCompletar;
    }
}