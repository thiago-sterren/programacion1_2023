using Biblioteca.Ejercicio_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Motos
{
    public partial class MotosDeportivas : Form
    {
        Principal principal = new Principal();
        public MotosDeportivas()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MotoDeportiva nueva_md = new MotoDeportiva(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
            principal.AgregarMotoDeportiva(nueva_md);
            MessageBox.Show("Se ha agregado una nueva moto deportiva a la lista");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.motos_d;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MotosDeportivas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            principal.BorrarMotoDeportiva((MotoDeportiva)listBox1.SelectedItem);
            MessageBox.Show("Se ha borrado la moto deportiva seleccionada de la lista");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.motos_d;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MotoDeportiva md_reemplazante = new MotoDeportiva(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
            principal.ModificarMotoDeportiva((MotoDeportiva)listBox1.SelectedItem, md_reemplazante);
            MessageBox.Show("Se ha modificado la moto deportiva");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.motos_d;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
