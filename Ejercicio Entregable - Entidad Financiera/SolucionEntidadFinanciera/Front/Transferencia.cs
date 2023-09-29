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
    public partial class Transferencia : Form
    {
        ApplicationDBContext context = new ApplicationDBContext();
        Principal principal = new Principal();
        public Transferencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(principal.RealizarTransferencia(int.Parse(textBox1.Text), int.Parse(textBox2.Text), double.Parse(textBox3.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovimientosFinancieros movFin = new MovimientosFinancieros();
            movFin.Show();
            this.Hide();
        }
    }
}
