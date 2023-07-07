using ClasesBiblioteca;
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
    public partial class AltaLibro : Form
    {
        Principal principal = new Principal();
        public AltaLibro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearLibro_Click(object sender, EventArgs e)
        {
            if (raBtnFisico.Checked)
            {
                LibroFisico nuevo_lf = new LibroFisico(txtTitulo.Text, txtAutor.Text, int.Parse(txtAnioPub.Text), true, int.Parse(txtNroPag.Text));
                principal.altaLibro(nuevo_lf);
                MessageBox.Show(nuevo_lf.ObtenerInformacion());
                listBoxLibros.DataSource = null;
                listBoxLibros.DisplayMember = "InfoParaElListBoxLibroFisico";
                listBoxLibros.DataSource = principal.lista_libros;
            } else if (raBtnDigital.Checked)
            {
                LibroDigital nuevo_ld = new LibroDigital(txtTitulo.Text, txtAutor.Text, int.Parse(txtAnioPub.Text), true, double.Parse(txtTamAr.Text), txtFor.Text);
                principal.altaLibro(nuevo_ld);
                MessageBox.Show(nuevo_ld.ObtenerInformacion());
                listBoxLibros.DataSource = null;
                listBoxLibros.DisplayMember = "InfoParaElListBoxLibroDigital";
            }
        }

        private void btnVolverLibro_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
