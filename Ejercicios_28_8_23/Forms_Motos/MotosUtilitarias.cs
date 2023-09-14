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
    public partial class MotosUtilitarias : Form
    {
        Principal principal = new Principal();
        public MotosUtilitarias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MotoUtilitaria nueva_mu = new MotoUtilitaria(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            principal.AgregarMotoUtilitaria(nueva_mu);
            MessageBox.Show("Se ha agregado una nueva moto utilitaria a la lista");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.motos_u;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            principal.BorrarMotoUtilitaria((MotoUtilitaria)listBox1.SelectedItem);
            MessageBox.Show("Se ha borrado la moto utilitaria seleccionada de la lista");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.motos_u;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MotoUtilitaria md_reemplazante = new MotoUtilitaria(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            principal.ModificarMotoUtilitaria((MotoUtilitaria)listBox1.SelectedItem, md_reemplazante);
            MessageBox.Show("Se ha modificado la moto utilitaria");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.motos_u;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
