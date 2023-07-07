using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBiblioteca
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaLibro altaLibro = new AltaLibro();
            altaLibro.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente();
            altaCliente.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaPrestamo altaPrestamo = new AltaPrestamo();
            altaPrestamo.Show();
            this.Hide();
        }
    }
}
