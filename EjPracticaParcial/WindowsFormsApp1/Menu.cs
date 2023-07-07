using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        List<Libro> lista_libros = new List<Libro>();
        List<Cliente> lista_clientes = new List<Cliente>();
        List<Prestamo> lista_prestamos = new List<Prestamo>();
        public Menu()
        {
            InitializeComponent();
        }
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
