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
            //Variables
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string carrera = txtCarrera.Text;

            //Mensaje
            lblMensaje.Text = $"Hola, soy {nombre} {apellido}, tengo {edad} años y estudio {carrera}.";

        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            { 
                txtApellido.Enabled = true;
            }
            else
            {
                txtApellido.Enabled = false;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "")
            {
                txtEdad.Enabled = true;
            }
            else
            {
                txtEdad.Enabled = false;
            }
        }

        private void txtCarrera_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCarrera.Text != "")
            {
                txtCarrera.Enabled = true;
                btnPresentar.Enabled = true;
            }
            else
            {
                txtCarrera.Enabled = false;
                btnPresentar.Enabled = false;
            }
        }

        private void txtEdad_TextChanged_1(object sender, EventArgs e)
        {
            if (txtEdad.Text != "")
            {
                txtCarrera.Enabled = true;
            }
            else
            {
                txtCarrera.Enabled = false;
            }
        }
    }
}
