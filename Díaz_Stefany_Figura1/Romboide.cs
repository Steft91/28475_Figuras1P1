using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2_StefanyDíaz
{
    public partial class Romboide : Form
    {
        public Romboide()
        {
            InitializeComponent();
        }

        private void lblTittle_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcRomboide_Click(object sender, EventArgs e)
        {
            try
            {
                double baseRomboide = double.Parse(txtBxBaseRomboide.Text);
                double alturaRomboide = double.Parse(txtBxAlturaRomboide.Text);
                double ladoRomboide = double.Parse(txtBxLadoRomboide.Text);

                if (baseRomboide <= 0 || alturaRomboide <= 0 || ladoRomboide <= 0)
                {
                    MessageBox.Show("No pueden ser valores negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double area = baseRomboide * alturaRomboide;
                double perimetro = 2 * (baseRomboide + ladoRomboide);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
