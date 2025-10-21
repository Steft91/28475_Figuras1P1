using System;
using System.Globalization;
using System.Windows.Forms;
using Actividad2_StefanyDíaz.Models;

namespace Actividad2_StefanyDíaz
{
    public partial class Triángulo : Form
    {
        public Triángulo()
        {
            InitializeComponent();
        }

        private void Triángulo_Load(object sender, EventArgs e) { }

        private void btnCalcularTri_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtBxBaseTri.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double baseTri))
                {
                    MessageBox.Show("Introduce un valor numérico válido para la base.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxBaseTri.Focus();
                    return;
                }
                if (!double.TryParse(txtBxAlturaTri.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double alturaTri))
                {
                    MessageBox.Show("Introduce un valor numérico válido para la altura.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxAlturaTri.Focus();
                    return;
                }

                // Mantengo comportamiento previo: si solo se indica base y altura, se asume equilátero para el perímetro.
                var triangulo = new Models.Triangulo(baseTri, alturaTri);
                double area = triangulo.Area();
                double perimetro = triangulo.Perimetro();

                MessageBox.Show($"El área es: {area:N4}\nEl perímetro es: {perimetro:N4}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("La base y la altura deben ser mayores que 0.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
