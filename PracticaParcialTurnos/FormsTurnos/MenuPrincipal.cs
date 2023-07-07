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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTurnoP_Click(object sender, EventArgs e)
        {
            PestanaTurnoPresencial pestanaTurnoPresencial = new PestanaTurnoPresencial();
            pestanaTurnoPresencial.Show();
            this.Hide();
        }

        private void btnTurnoV_Click(object sender, EventArgs e)
        {
            PestanaTurnoVirtual pestanaTurnoVirtual = new PestanaTurnoVirtual();
            pestanaTurnoVirtual.Show();
            this.Hide();
        }
    }
}
