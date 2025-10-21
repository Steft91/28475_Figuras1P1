using System;
using System.Globalization;
using System.Windows.Forms;
using Actividad2_StefanyDíaz.Models;

namespace Actividad2_StefanyDíaz
{
    public partial class Rombo : Form
    {
        public Rombo()
        {
            InitializeComponent();
        }

        private void Rombo_Load(object sender, EventArgs e) { }

        private void lblAltura_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void txtBxDiagMay_TextChanged(object sender, EventArgs e) { }

        private void btnCalcRombo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtBxDiagMay.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double diagMay))
                {
                    MessageBox.Show("Introduce un valor numérico válido para la diagonal mayor.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxDiagMay.Focus();
                    return;
                }
                if (!double.TryParse(txtBxDiagMen.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double diagMen))
                {
                    MessageBox.Show("Introduce un valor numérico válido para la diagonal menor.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxDiagMen.Focus();
                    return;
                }

                var rombo = new Models.Rombo(diagMay, diagMen);
                double area = rombo.Area();
                double perimetro = rombo.Perimetro();

                MessageBox.Show($"El área es: {area:N4}\nEl perímetro es: {perimetro:N4}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Las diagonales deben ser mayores que 0.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
