using System;
using System.Globalization;
using System.Windows.Forms;
using Actividad2_StefanyDíaz.Models;

namespace Actividad2_StefanyDíaz
{
    public partial class Polígono : Form
    {
        public Polígono()
        {
            InitializeComponent();
        }

        private void btnCalcPoli_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtBxLadoPoli.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double lado))
                {
                    MessageBox.Show("Introduce un valor numérico válido para el lado.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxLadoPoli.Focus();
                    return;
                }
                if (!int.TryParse(txtBxNumLados.Text.Trim(), out int numLados))
                {
                    MessageBox.Show("Introduce un número entero válido para el número de lados.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxNumLados.Focus();
                    return;
                }
                if (!double.TryParse(txtBxApotema.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double apotema))
                {
                    MessageBox.Show("Introduce un valor numérico válido para la apotema.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxApotema.Focus();
                    return;
                }

                var poli = new PoligonoRegular(lado, numLados, apotema);
                double perimetro = poli.Perimetro();
                double area = poli.Area();

                MessageBox.Show($"El área es: {area:N4}\nEl perímetro es: {perimetro:N4}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Los valores deben ser mayores que 0 y el número de lados al menos 3.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
