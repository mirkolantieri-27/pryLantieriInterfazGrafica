using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryLantieriInterfazGrafica
{
    public partial class frmCalculadoraBasica : Form
    {
        //variables globales del form

        double num1, num2, calculo;
        public frmCalculadoraBasica()
        {
            InitializeComponent();
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtN1.Text);
            double num2 = double.Parse(txtN2.Text);

            //calculo suma
            calculo = num1 + num2;

            txtResult.Text = calculo.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtN1.Text);
            double num2 = double.Parse(txtN2.Text);

            //calculo resta
            calculo = num1 - num2;

            txtResult.Text = calculo.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtN1.Text);
            double num2 = double.Parse(txtN2.Text);

            //calculo multiplicacion
            calculo = num1 * num2;

            txtResult.Text = calculo.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtN1.Text);
            double num2 = double.Parse(txtN2.Text);

            //calculo division
            calculo = num1 / num2;

            txtResult.Text = calculo.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}
