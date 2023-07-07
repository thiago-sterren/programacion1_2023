using ClasesTiendaDeLibros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLibreria
{
    public partial class ABMLibros : Form
    {
        Principal principal = new Principal();
        public ABMLibros()
        {
            InitializeComponent();
        }

        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            LibroFisico nuevo_lf = new LibroFisico(txtISBN.Text, txtTitulo.Text, txtAutor.Text, double.Parse(txtPrecio.Text), int.Parse(txtNroPags.Text), double.Parse(txtPeso.Text));
            principal.AltaLibro(nuevo_lf);
            MessageBox.Show($"Ha creado el nuevo libro fisico '{nuevo_lf.titulo}' del autor {nuevo_lf.autor}.");
            listBoxLibros.DataSource = null;
            listBoxLibros.DisplayMember = "titulo";
            listBoxLibros.DataSource = principal.lista_libros;
        }

        private void btnAltaLibroDigital_Click(object sender, EventArgs e)
        {
            LibroDigital nuevo_ld = new LibroDigital(txtISBN.Text, txtTitulo.Text, txtAutor.Text, double.Parse(txtPrecio.Text), txtFormato.Text, double.Parse(txtTamanio.Text));
            principal.AltaLibro(nuevo_ld);
            MessageBox.Show($"Ha creado el nuevo libro fisico '{nuevo_ld.titulo}' del autor {nuevo_ld.autor}.");
            listBoxLibros.DataSource = null;
            listBoxLibros.DisplayMember = "titulo";
            listBoxLibros.DataSource = principal.lista_libros;
        }

        private void btnBajaLibro_Click(object sender, EventArgs e)
        {
            Libro libro_seleccionado = (Libro)listBoxLibros.SelectedItem;
            principal.BajaLibro(libro_seleccionado);
            MessageBox.Show($"Has dado de baja el prestamo del libro '{libro_seleccionado.titulo}'.");
            listBoxLibros.DataSource = null;
            listBoxLibros.DisplayMember = "titulo";
            listBoxLibros.DataSource = principal.lista_libros;
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            
        }
    }
}
