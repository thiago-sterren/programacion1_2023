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
    public partial class PestanaTurnoPresencial : Form
    {
        Principal principal = new Principal();
        public PestanaTurnoPresencial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurnoPresencial nuevo_tp = new TurnoPresencial(dateTimePicker1.Value, int.Parse(txtDuracionTP.Text), txtLugarTP.Text);
            principal.altaTurnoPresencial(nuevo_tp);
            MessageBox.Show(nuevo_tp.MostrarInformacion());
            listBox1.DataSource = null;
            listBox1.DisplayMember = "InfoTP";
            listBox1.DataSource = principal.lista_turnos_presenciales;
        }

        private void btnVolverTP_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PestanaTurnoPresencial_Load(object sender, EventArgs e)
        {
            
        }
    }
}
