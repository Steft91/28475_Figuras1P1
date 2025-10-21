using System;
using System.Globalization;
using System.Windows.Forms;
using Actividad2_StefanyDíaz.Models;

namespace Actividad2_StefanyDíaz
{
    public partial class Cuadrado : Form
    {
        public Cuadrado()
        {
            InitializeComponent();
        }

        private void lblTittle_Click(object sender, EventArgs e) { }

        private void txtBxBase_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void lblAltura_Click(object sender, EventArgs e) { }

        private void lblBase_Click(object sender, EventArgs e) { }

        private void txtBxAltura_TextChanged(object sender, EventArgs e) { }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtBxLado.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double lado))
                {
                    MessageBox.Show("Introduce un valor numérico válido para el lado.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxLado.Focus();
                    return;
                }

                // Instanciar explícitamente la clase modelo para evitar conflicto de nombres con el Form
                var modelo = new Actividad2_StefanyDíaz.Models.Cuadrado(lado);
                double area = modelo.Area();
                double perimetro = modelo.Perimetro();

                MessageBox.Show($"El área es: {area:N4}\nEl perímetro es: {perimetro:N4}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("El lado debe ser mayor que 0.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
