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
    public partial class PestanaCliente : Form
    {
        Principal principal = new Principal();
        public PestanaCliente()
        {
            InitializeComponent();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevo_cliente = new Cliente(int.Parse(txtDNICliente.Text), txtNombreCliente.Text, txtApellidoCliente.Text);
            principal.altaCliente(nuevo_cliente);
            MessageBox.Show("Nuevo cliente creado");
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
