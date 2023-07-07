using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesDeLaBiblioteca;

namespace FormsDeLaBiblioteca
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PestanaLibro pestanaLibro = new PestanaLibro();
            pestanaLibro.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PestanaCliente pestanaCliente = new PestanaCliente();
            pestanaCliente.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PestanaPrestamo pestanaPrestamo = new PestanaPrestamo();
            pestanaPrestamo.Show();
            this.Hide();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            PestanaPrueba pestanaPrueba = new PestanaPrueba();
            pestanaPrueba.Show();
            this.Hide();
        }
    }
}
