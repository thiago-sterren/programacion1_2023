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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente nuevoCliente = new NuevoCliente();
            nuevoCliente.Show();
            this.Hide();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            NuevaCuenta nuevaCuenta = new NuevaCuenta();
            nuevaCuenta.Show();
            this.Hide();
        }

        private void btnEmitirTarjeta_Click(object sender, EventArgs e)
        {
            EmitirTarjeta emitirTarjeta = new EmitirTarjeta();
            emitirTarjeta.Show();
            this.Hide();
        }

        private void btnMiTarjeta_Click(object sender, EventArgs e)
        {
            ControlarMiTarjeta ControlarMiTarjeta = new ControlarMiTarjeta();
            ControlarMiTarjeta.Show();
            this.Hide();
        }

        private void btnMovDinero_Click(object sender, EventArgs e)
        {
            MovimientosFinancieros movFin = new MovimientosFinancieros();
            movFin.Show();
            this.Hide();
        }
    }
}
