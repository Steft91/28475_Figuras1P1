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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void rectánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuadrado frmCuad = new Cuadrado();
            frmCuad.MdiParent = this;
            frmCuad.Show();
        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triángulo frmTri = new Triángulo();
            frmTri.MdiParent = this;
            frmTri.Show();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rombo frmRombo = new Rombo();   
            frmRombo.MdiParent = this;
            frmRombo.Show();
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romboide frmRomboide = new Romboide();
            frmRomboide.MdiParent = this;
            frmRomboide.Show();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trapecio frmTrapecio = new Trapecio();
            frmTrapecio.MdiParent = this;
            frmTrapecio.Show();
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Círculo frmCirculo = new Círculo();
            frmCirculo.MdiParent = this;
            frmCirculo.Show();
        }

        private void polígonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polígono frmPoli = new Polígono();
            frmPoli.MdiParent = this;
            frmPoli.Show();
        }
    }
}
