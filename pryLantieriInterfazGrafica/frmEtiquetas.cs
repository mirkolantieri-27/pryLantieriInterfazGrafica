using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryLantieriInterfazGrafica
{
    public partial class frmEtiquetas : Form
    {
        public frmEtiquetas()
        {
            InitializeComponent();
        }

        private void frmEtiquetas_Load(object sender, EventArgs e)
        {

        }

        private void btnPresentar_Click(object sender, EventArgs e)
        {

        }

        private void btnPresentar_Click_1(object sender, EventArgs e)
        {
            //Variables
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string carrera = txtCarrera.Text;

           //Mensaje
            lblMensaje.Text = $"Hola, soy {nombre} {apellido}, tengo {edad} años y estudio {carrera}.";
        }
    }
}
