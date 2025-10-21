using System;
using System.Globalization;
using System.Windows.Forms;

namespace Actividad2_StefanyDíaz
{
    public partial class Trapecio : Form
    {
        public Trapecio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcTrapecio_Click(object sender, EventArgs e)
        {
            try
            {
                double baseMayor = double.Parse(txtBxBasMayor.Text);
                double baseMenor = double.Parse(txtBxBasMenor.Text);
                double altura = double.Parse(txtBxAltTrapecio.Text);
                double lado1 = double.Parse(txtBxLadoTrapecio.Text);

                if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0 || lado1 <= 0)
                {
                    MessageBox.Show("No pueden ser valores negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double area = ((baseMayor + baseMenor) / 2) * altura;
                double perimetro = baseMayor + baseMenor + 2 * lado1;
                MessageBox.Show($"El área es: {area}\nEl perímetro es: {perimetro}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException)
            {
                MessageBox.Show("Valores no válidos", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Trapecio_Load(object sender, EventArgs e)
        {

        }
    }
}
