namespace pryLantieriInterfazGrafica
{
    partial class frmSistemaGestion
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
            btnClientes = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnReportes = new Button();
            btnConfiguracion = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(51, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(248, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE GESTIÓN";
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            btnClientes.Location = new Point(51, 48);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(103, 32);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            btnProductos.Location = new Point(51, 86);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(119, 32);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            btnVentas.Location = new Point(51, 124);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(84, 32);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            btnReportes.Location = new Point(51, 162);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(103, 32);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "REPORTES";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            btnConfiguracion.Location = new Point(51, 212);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(153, 32);
            btnConfiguracion.TabIndex = 5;
            btnConfiguracion.Text = "CONFIGURACIÓN";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold);
            btnSalir.Location = new Point(51, 250);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(66, 32);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmSistemaGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 294);
            Controls.Add(btnSalir);
            Controls.Add(btnConfiguracion);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Controls.Add(btnProductos);
            Controls.Add(btnClientes);
            Controls.Add(lblTitulo);
            Name = "frmSistemaGestion";
            Text = "Caso 10 - Sistema Integral de Gestión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnClientes;
        private Button btnProductos;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnConfiguracion;
        private Button btnSalir;
    }
}