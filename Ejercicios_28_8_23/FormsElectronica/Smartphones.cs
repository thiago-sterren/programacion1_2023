﻿using Biblioteca_Ejercicio_2;
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
    public partial class Smartphones : Form
    {
        Principal principal = new Principal();
        public Smartphones()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Smartphone sp_nuevo = new Smartphone(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            principal.AgregarSmartphone(sp_nuevo);
            MessageBox.Show("Se ha agregado un nuevo smartphone");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.smartphones;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            principal.EliminarSmartphone((Smartphone)listBox1.SelectedItem);
            MessageBox.Show("Se ha eliminado el smartphone seleccionado");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.smartphones;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Smartphone reemplazo = new Smartphone(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            principal.ModificarSmartphone((Smartphone)listBox1.SelectedItem, reemplazo);
            MessageBox.Show("Modificacion realizada");
            listBox1.DataSource = null;
            listBox1.DisplayMember = "texto";
            listBox1.DataSource = principal.smartphones;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
