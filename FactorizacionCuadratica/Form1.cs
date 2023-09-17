using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorizacionCuadratica
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCoeficienteA.Text = "";
            txtCoeficienteB.Text = "";
            txtCoeficienteC.Text = "";
            txtResultado.Text = "";
        }

        private void txtCoeficienteC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener los coeficientes a, b y c desde los TextBox
            if (double.TryParse(txtCoeficienteA.Text, out double a) &&
                double.TryParse(txtCoeficienteB.Text, out double b) &&
                double.TryParse(txtCoeficienteC.Text, out double c))
            {
                // Calcular el discriminante
                double discriminante = Math.Pow(b, 2) - 4 * a * c;

                if (discriminante > 0)
                {
                    // Dos soluciones reales distintas
                    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    txtResultado.Text = $"x1 = {x1}, x2 = {x2}";
                }
                else if (discriminante == 0)
                {
                    // Una solución real (raíz doble)
                    double x = -b / (2 * a);
                    txtResultado.Text = $"x = {x}";
                }
                else
                {
                    // Soluciones complejas
                    double realPart = -b / (2 * a);
                    double imaginaryPart = Math.Sqrt(-discriminante) / (2 * a);
                    txtResultado.Text = $"x1 = {realPart} + {imaginaryPart}i, x2 = {realPart} - {imaginaryPart}i";
                }
            }
            else
            {
                // Manejo de error si los coeficientes no son válidos
                txtResultado.Text = "Por favor, ingrese coeficientes válidos.";
            }
        }
    }
}
