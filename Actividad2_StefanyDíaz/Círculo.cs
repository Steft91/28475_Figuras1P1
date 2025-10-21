using System;
using System.Globalization;
using System.Windows.Forms;
using Actividad2_StefanyDíaz.Models;

namespace Actividad2_StefanyDíaz
{
    public partial class Círculo : Form
    {
        public Círculo()
        {
            InitializeComponent();
        }

        private void btnCalcCirculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtBxRadio.Text.Trim(), System.Globalization.NumberStyles.Float | System.Globalization.NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double radio))
                {
                    MessageBox.Show("Introduce un valor numérico válido para el radio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxRadio.Focus();
                    return;
                }

                var circulo = new Circulo(radio);
                double area = circulo.Area();
                double perimetro = circulo.Perimetro();

                MessageBox.Show($"El área es: {area:N4}\nLa circunferencia (perímetro) es: {perimetro:N4}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("El radio debe ser mayor que 0.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxRadio.Focus();
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

        private void lblTittle_Click(object sender, EventArgs e) { }
    }
}
