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
    public partial class MovimientosFinancieros : Form
    {
        ApplicationDBContext context = new ApplicationDBContext();
        Principal principal = new Principal();
        public MovimientosFinancieros()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(principal.RealizarDeposito(int.Parse(textBox1.Text), double.Parse(textBox2.Text)));
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(principal.RealizarExtraccion(int.Parse(textBox1.Text), double.Parse(textBox2.Text)));
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Transferencia transferencia = new Transferencia();
            transferencia.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
