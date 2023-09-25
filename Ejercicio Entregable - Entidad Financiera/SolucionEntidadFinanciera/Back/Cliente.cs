using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public TarjetaCredito tarjetaCredito { get; set; }
        public CuentaBancaria cuentaBancaria { get; set; }
        public Cliente(string nombre, string apellido, int dni, TarjetaCredito tarjetaCredito, CuentaBancaria cuentaBancaria)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.tarjetaCredito = tarjetaCredito;
            this.cuentaBancaria = cuentaBancaria;
        }
    }
}
