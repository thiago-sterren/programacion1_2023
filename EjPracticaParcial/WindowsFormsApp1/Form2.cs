using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Principal principal = new Principal();
        List<Cliente> lista_clientes = new List<Cliente>();
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Cliente nuevo_cliente = new Cliente(int.Parse(txtDNICliente.Text), txtNombreCliente.Text, txtApellidoCliente.Text);
            principal.altaCliente(nuevo_cliente);
        }
    }
}
