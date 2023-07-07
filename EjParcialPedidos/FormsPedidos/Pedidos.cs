using BibliotecaPedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPedidos
{
    public partial class Pedidos : Form
    {
        Principal principal = new Principal();
        public Pedidos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarPedLoc_Click(object sender, EventArgs e)
        {
            PedidoLocal nuevo_pl = new PedidoLocal(int.Parse(txtNumero.Text), dateTimePicker1.Value, double.Parse(txtPrecio.Text), txtSucursal.Text);
            principal.altaPedidoLocal(nuevo_pl);
            MessageBox.Show(nuevo_pl.MostrarDetalles());
            listBox1.DataSource = null;
            listBox1.DisplayMember = "InfoPL";
            listBox1.DataSource = principal.lista_pedidos_locales;
        }

        private void btnAgregarPedOnl_Click(object sender, EventArgs e)
        {
            PedidoOnline nuevo_po = new PedidoOnline(int.Parse(txtNumero.Text), dateTimePicker1.Value, double.Parse(txtPrecio.Text), txtDireccion.Text);
            principal.altaPedidoOnline(nuevo_po);
            MessageBox.Show(nuevo_po.MostrarDetalles());
            listBox2.DataSource = null;
            listBox2.DisplayMember = "InfoPO";
            listBox2.DataSource = principal.lista_pedidos_online;
        }
    }
}
