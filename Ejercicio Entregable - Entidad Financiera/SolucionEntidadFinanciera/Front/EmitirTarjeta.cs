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
    public partial class EmitirTarjeta : Form
    {
        Principal principal = new Principal();
        public EmitirTarjeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TarjetaCredito tc = new TarjetaCredito();
            Cliente? clienteSeleccionado = (Cliente)listBox1.SelectedItem;
            if (textBox1.Text == "" || textBox2.Text == "" || listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
            else
            {
                clienteSeleccionado.cantidadTarjetas += 1;
                tc.limiteCredito = double.Parse(textBox1.Text);
                tc.saldoDisponible = double.Parse(textBox2.Text);
                tc.idClienteTitular = clienteSeleccionado;
                tc.numeroTarjeta = $"{tc.id} {clienteSeleccionado.id} {clienteSeleccionado.dni} {clienteSeleccionado.cantidadTarjetas}";
                principal.EmitirTarjetaCredito(tc);
                MessageBox.Show($"Tarjeta emitida con éxito. Podrá retirarla en su sucursal más cercana a partir del 5to día hábil de emisión con el siguiente número de tarjeta: {tc.id} {clienteSeleccionado.id} {clienteSeleccionado.dni} {clienteSeleccionado.cantidadTarjetas}");
            }
        }

        private void EmitirTarjeta_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "info_list_box";
            listBox1.DataSource = principal.DevolverListaClientes();
        }
    }
}
