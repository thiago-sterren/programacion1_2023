using BibliotecaTurnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTurnos
{
    public partial class PestanaTurnoVirtual : Form
    {
        Principal principal = new Principal();
        public PestanaTurnoVirtual()
        {
            InitializeComponent();
        }

        private void btnReservarTV_Click(object sender, EventArgs e)
        {
            TurnoVirtual turnoVirtual = new TurnoVirtual(dateTimePicker2.Value, int.Parse(txtDuracionTV.Text), txtPlataformaTV.Text);
            principal.altaTurnoVirtual(turnoVirtual);
            MessageBox.Show(turnoVirtual.MostrarInformacion());
            listBox1.DataSource = null;
            listBox1.DisplayMember = "InfoTV";
            listBox1.DataSource = principal.lista_turnos_virtuales;
        }

        private void btnVolverTV_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
