using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class NuevoCliente : Form
    {
        ApplicationDBContext context = new ApplicationDBContext();
        Principal principal = new Principal();
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            principal.AgregarCliente(cliente);
            int dniIngresado = int.Parse(textBox3.Text);
            if ()
            {

            }
        }
    }
}
