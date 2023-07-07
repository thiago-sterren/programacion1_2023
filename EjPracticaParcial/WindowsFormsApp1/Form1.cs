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
    public partial class Form1 : Form
    {
        Principal principal = new Principal();
        List<Libro> lista_libros = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCrearLD_Click(object sender, EventArgs e)
        {
            LibroDigital nuevo_ld = new LibroDigital(txtTituloLD.Text, txtAutorLD.Text, int.Parse(txtAnioPubLD.Text), true, double.Parse(txtTamArch.Text), txtFormato.Text);
            principal.altaLibro(nuevo_ld);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void txtOpcLibro1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtOpLibro2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearLF_Click(object sender, EventArgs e)
        {
            LibroFisico nuevo_lf = new LibroFisico(txtTituloLF.Text, txtAutorLF.Text, int.Parse(txtAnioPubLF.Text), true, int.Parse(txtNumPags.Text));
            principal.altaLibro(nuevo_lf);
        }
    }
}
