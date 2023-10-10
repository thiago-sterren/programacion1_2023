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
        ApplicationDBContext context = new ApplicationDBContext();
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
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuentaBancaria cb = new CuentaBancaria();
            Cliente? clienteSeleccionado = (Cliente)listBox1.SelectedItem;
            if (textBox1.Text == "" || comboBox1.SelectedItem == null || listBox1.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos, por favor");
            }
            else
            {
                clienteSeleccionado.cantidadCuentas += 1;
                cb.saldo = double.Parse(textBox1.Text);
                if (comboBox1.SelectedIndex == 0)
                {
                    cb.tipo = CuentaBancaria.Tipo.Corriente;
                    cb.numeroCuenta = $"0000 {clienteSeleccionado.id} {clienteSeleccionado.dni} {clienteSeleccionado.cantidadCuentas}";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    cb.tipo = CuentaBancaria.Tipo.Ahorro;
                    cb.numeroCuenta = $"1111 {clienteSeleccionado.id} {clienteSeleccionado.dni} {clienteSeleccionado.cantidadCuentas}";
                }
                cb.idClienteTitular = clienteSeleccionado;
                principal.CrearCuentaBancaria(cb);
                MessageBox.Show("Se ha creado una nueva cuenta");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
