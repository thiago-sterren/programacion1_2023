using ClasesDeLaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDeLaBiblioteca
{
    public partial class PestanaPrueba : Form
    {
        Principal principal = new Principal();
        public PestanaPrueba()
        {
            InitializeComponent();
        }

        private void PestanaPrueba_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevo_cliente = new Cliente(int.Parse(txtDNICliente.Text), txtNombreCliente.Text, txtApellidoCliente.Text);
            principal.altaCliente(nuevo_cliente);
            MessageBox.Show($"Se ha creado el nuevo cliente {nuevo_cliente.nombre} {nuevo_cliente.apellido}");
            comboBoxClientes.DataSource = null;
            comboBoxClientes.DisplayMember = "dni";
            comboBoxClientes.ValueMember = null;
            comboBoxClientes.DataSource = principal.lista_clientes;
        }

        private void btnCrearLD_Click(object sender, EventArgs e)
        {
            LibroDigital nuevo_ld = new LibroDigital(txtTituloLD.Text, txtAutorLD.Text, int.Parse(txtAnioPubLD.Text), true, double.Parse(txtTamArchLD.Text), txtFormatoLD.Text);
            principal.altaLibro(nuevo_ld);
            MessageBox.Show($"Se ha creado el nuevo libro {nuevo_ld.titulo} de {nuevo_ld.autor}");
            comboBoxLibros.DataSource = null;
            comboBoxLibros.DisplayMember = "titulo";
            comboBoxLibros.ValueMember = null;
            comboBoxLibros.DataSource = principal.lista_libros;

        }

        private void btnCrearLF_Click(object sender, EventArgs e)
        {
            LibroFisico nuevo_lf = new LibroFisico(txtTituloLF.Text, txtAutorLF.Text, int.Parse(txtAnioPubLF.Text), true, int.Parse(txtNumPagsLF.Text));
            principal.altaLibro(nuevo_lf);
            MessageBox.Show($"Se ha creado el nuevo libro {nuevo_lf.titulo} de {nuevo_lf.autor}");
            comboBoxLibros.DataSource = null;
            comboBoxLibros.DisplayMember = "titulo";
            comboBoxLibros.ValueMember = null;
            comboBoxLibros.DataSource = principal.lista_libros;
            
        }

        private void btnCrearPrestamo_Click(object sender, EventArgs e)
        {
            Cliente cliente_seleccionado = (Cliente)comboBoxClientes.SelectedItem;
            Libro libro_seleccionado = (Libro)comboBoxLibros.SelectedItem;
            Prestamo nuevo_p = new Prestamo(dateTimePickerPrestamo.Value, dateTimePickerDevolucion.Value, cliente_seleccionado, libro_seleccionado);
            principal.altaPrestamo(nuevo_p);
            MessageBox.Show($"Se ha realizado un nuevo prestamo. El cliente {cliente_seleccionado.nombre} {cliente_seleccionado.apellido} se ha llevado el libro '{libro_seleccionado.titulo}'. Inicio del prestamo: {dateTimePickerPrestamo.Value}. Fecha de devolucion: {dateTimePickerDevolucion.Value}.");
            listBoxPrestamos.DataSource = null;
            listBoxPrestamos.DisplayMember = "InfoPrestamo";
            listBoxPrestamos.DataSource = principal.lista_prestamos;
        }

        private void btnBajaPrestamo_Click(object sender, EventArgs e)
        {
            Prestamo prestamo_seleccionado = (Prestamo)listBoxPrestamos.SelectedItem;
            principal.bajaPrestamo(prestamo_seleccionado);
            MessageBox.Show($"Has dado de baja el prestamo del libro {prestamo_seleccionado.libroPrestamo.titulo}.");
            listBoxPrestamos.DataSource = null;
            listBoxPrestamos.DisplayMember = "InfoPrestamo";
            listBoxPrestamos.DataSource = principal.lista_prestamos;
        }
    }
}
