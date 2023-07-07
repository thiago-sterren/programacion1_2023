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
    public partial class PestanaPrestamo : Form
    {
        public Principal principal;
        public PestanaPrestamo()
        {
            InitializeComponent();
            principal = new Principal();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVolverPrestamo_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void PestanaPrestamo_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = principal.lista_clientes;
            comboBox2.DataSource = principal.lista_libros;
        }
    }
}
