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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Front
{
    public partial class NuevoCliente : Form
    {
        ApplicationDBContext context = new ApplicationDBContext();
        Principal principal = new Principal();
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int dniIngresado = int.Parse(textBox3.Text);
            Cliente? clienteBuscado = context.Clientes.SingleOrDefault(c => c.dni == dniIngresado);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedIndex == null || textBox4.Text == "")
            {
                MessageBox.Show("Complete todos los campos, por favor");
            }
            else
            {
                if (clienteBuscado == null)
                {
                    Cliente clienteNuevo = new Cliente(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
                    clienteNuevo.cantidadCuentas += 1;
                    principal.AgregarCliente(clienteNuevo);
                    CuentaBancaria cb = new CuentaBancaria();
                    cb.saldo = double.Parse(textBox4.Text);
                    if (comboBox1.SelectedIndex == 0)
                    {
                        cb.tipo = CuentaBancaria.Tipo.Corriente;
                        cb.numeroCuenta = $"0000 {clienteNuevo.id} {clienteNuevo.dni} {clienteNuevo.cantidadCuentas}";
                    }
                    else
                    {
                        cb.tipo = CuentaBancaria.Tipo.Ahorro;
                        cb.numeroCuenta = $"1111 {clienteNuevo.id} {clienteNuevo.dni} {clienteNuevo.cantidadCuentas}";
                    }
                    cb.idClienteTitular = clienteNuevo;
                    principal.CrearCuentaBancaria(cb);
                    MessageBox.Show("Se ha creado un nuevo cliente con su respectiva cuenta");
                }
                else
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI, por favor, ingrese otro");
                }
            }
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Corriente");
            comboBox1.Items.Add("Ahorro");
        }
    }
}
