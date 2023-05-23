using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo nuevo_circulo = new Circulo();
            double radio_double = double.Parse(textBoxRadio.Text);
            nuevo_circulo.radio = radio_double;
            nuevo_circulo.nombre = textBoxNombre.Text;
            MessageBox.Show(nuevo_circulo.DecimeQuienSos());
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRadio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
