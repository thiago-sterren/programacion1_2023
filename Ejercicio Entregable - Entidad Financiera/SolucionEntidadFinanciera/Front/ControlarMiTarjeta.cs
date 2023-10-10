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
    public partial class ControlarMiTarjeta : Form
    {
        Principal principal = new Principal();
        ApplicationDBContext context = new ApplicationDBContext();
        public ControlarMiTarjeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TarjetaCredito? tc = context.Tarjetas.FirstOrDefault(tc => tc.numeroTarjeta == textBox1.Text);
            if (tc != null)
            {
                MessageBox.Show($"Su deuda es de ${tc.MontoDeuda}");
            }
            else
            {
                MessageBox.Show("No existe una tarjeta con ese número");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(principal.PagarTarjetaCredito(textBox1.Text, double.Parse(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.ReactivarTarjetaCredito(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            principal.PausarTarjetaCredito(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            principal.BloquearTarjetaCredito(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
