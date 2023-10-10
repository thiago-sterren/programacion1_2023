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
    public partial class MiTarjeta : Form
    {
        ApplicationDBContext context = new ApplicationDBContext();
        Principal principal = new Principal();
        public MiTarjeta()
        {
            InitializeComponent();
        }

        private void btnDeuda_Click(object sender, EventArgs e)
        {
            TarjetaCredito? tc = context.Tarjetas.Find(int.Parse(textBox1.Text));
            if (tc != null)
            {
                MessageBox.Show($"Su deuda es de ${tc.MontoDeuda}");
            }
            else
            {
                MessageBox.Show("No existe una tarjeta con ese número");
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(principal.PagarTarjetaCredito(textBox1.Text, double.Parse(textBox2.Text)));
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            principal.PausarTarjetaCredito(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
