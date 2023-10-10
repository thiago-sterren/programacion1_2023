using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class NuevaCuenta : Form
    {
        Principal principal = new Principal();
        public NuevaCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string estadoSeleccionado = comboBox1.SelectedItem.ToString();
        }

        private void NuevaCuenta_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Corriente");
            comboBox1.Items.Add("Ahorro");
            foreach (Cliente cliente in principal.DevolverListaClientes())
            {
                comboBox2.Items.Add($"{cliente.nombre} {cliente.apellido}. ID: {cliente.id}.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuentaBancaria cb = new CuentaBancaria();
            Cliente clienteSeleccionado = (Cliente)comboBox2.SelectedItem;
            if (textBox1.Text == null)
            {
                MessageBox.Show("Ingrese el saldo para esta nueva cuenta bancaria");
            }
            else
            {
                cb.saldo = double.Parse(textBox1.Text);
            }
            if (comboBox1.SelectedIndex == 0)
            {
                cb.tipo = CuentaBancaria.Tipo.Corriente;
                cb.numeroCuenta = $"0000 {clienteSeleccionado.id} {clienteSeleccionado.dni}";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                cb.tipo = CuentaBancaria.Tipo.Ahorro;
                cb.numeroCuenta = $"1111 {clienteSeleccionado.id} {clienteSeleccionado.dni}";
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de cuenta bancaria, por favor");
            }
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el cliente al que quiere asignarle esta nueva cuenta bancaria, por favor");
            }
            else
            {
                cb.idClienteTitular = clienteSeleccionado;
            }
            principal.CrearCuentaBancaria(cb);
        }
    }
}
