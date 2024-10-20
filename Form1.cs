using System;
using System.Windows.Forms;

namespace TecIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        private void btnSimular_Click(object sender, EventArgs e)
        {

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que los valores ingresados en los TextBox sean numéricos
            if (double.TryParse(txtDecaimientoI.Text, out double decaimientoInicial) &&
                double.TryParse(txtTasaD.Text, out double tasaDecaimiento) &&
                int.TryParse(txtDistancia.Text, out int distanciaMax))
            {
                // Limpiar el Label antes de empezar la simulación
                lblRes.Text = "Distancia\t             Cantidad de Cristales\n";

                // Bucle para simular el decaimiento de cristales
                for (int i = 0; i <= distanciaMax; i++)
                {
                    double distancia = i; // Aumentamos la distancia
                    double cantidadCristales = decaimientoInicial * Math.Exp(-tasaDecaimiento * distancia);
                    lblRes.Text += $"{distancia}\t                          \t{cantidadCristales:F2}\n";
                }

                lblRes.Text += "\nTerminada";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }
    }
}
