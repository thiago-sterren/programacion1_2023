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
    public partial class PestanaLibro : Form
    {
        Principal principal = new Principal();
        public PestanaLibro()
        {
            InitializeComponent();
        }

        private void btnCrearLD_Click(object sender, EventArgs e)
        {
            LibroDigital nuevo_ld = new LibroDigital(txtTituloLD.Text, txtAutorLD.Text, int.Parse(txtAnioPubLD.Text), true, double.Parse(txtTamArchLD.Text), txtFormatoLD.Text);
            principal.altaLibro(nuevo_ld);
            MessageBox.Show("Nuevo libro digital creado");
        }

        private void btnCrearLF_Click(object sender, EventArgs e)
        {
            LibroFisico nuevo_lf = new LibroFisico(txtTituloLF.Text, txtAutorLF.Text, int.Parse(txtAnioPubLF.Text), true, int.Parse(txtNumPagsLF.Text));
            principal.altaLibro(nuevo_lf);
            MessageBox.Show("Nuevo libro fisico creado");
        }

        private void btnVolverLibro_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
