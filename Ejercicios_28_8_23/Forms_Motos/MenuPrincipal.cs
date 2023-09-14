using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Motos
{
    public partial class MenuPrincipal : Form
    {
        MotosDeportivas motosDeportivas = new MotosDeportivas();
        MotosUtilitarias motosUtilitarias = new MotosUtilitarias();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            motosDeportivas.Show();
        }

        private void btnUti_Click(object sender, EventArgs e)
        {
            motosUtilitarias.Show();
        }
    }
}
