using System;
using System.Globalization;
using System.Windows.Forms;
using Actividad2_StefanyDíaz.Models;

namespace Actividad2_StefanyDíaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Parseo seguro según cultura
                if (!double.TryParse(txtBxBase.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double baseRect))
                {
                    MessageBox.Show("Introduce un valor numérico válido para la base.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxBase.Focus();
                    return;
                }
                if (!double.TryParse(txtBxAltura.Text.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double alturaRect))
                {
                    MessageBox.Show("Introduce un valor numérico válido para la altura.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxAltura.Focus();
                    return;
                }

                // Usar la clase dominio
                var rect = new Rectangulo(baseRect, alturaRect);
                double area = rect.Area();
                double perimetro = rect.Perimetro();

                MessageBox.Show($"El área es: {area}\nEl perímetro es: {perimetro}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("La base y la altura deben ser mayores que 0.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBxBase_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void lblAltura_Click(object sender, EventArgs e) { }

        private void txtBxAltura_TextChanged(object sender, EventArgs e) { }
    }
}
