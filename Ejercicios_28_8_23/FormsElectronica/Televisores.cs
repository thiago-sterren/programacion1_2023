using Biblioteca_Ejercicio_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsElectronica
{
    public partial class Televisores : Form
    {
        Principal principal = new Principal();
        public Televisores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Televisor tele_nuevo = new Televisor(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            principal.AgregarTelevisor(tele_nuevo);
            MessageBox.Show("Se ha agregado un nuevo televisor");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.televisores;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            principal.EliminarTelevisor((Televisor)listBox1.SelectedItem);
            MessageBox.Show("Se ha eliminado el televisor seleccionado");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.televisores;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Televisor reemplazo = new Televisor(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            principal.ModificarTelevisor((Televisor)listBox1.SelectedItem, reemplazo);
            MessageBox.Show("Modificacion realizada");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.televisores;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
