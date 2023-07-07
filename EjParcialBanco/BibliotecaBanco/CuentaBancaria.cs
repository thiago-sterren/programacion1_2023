using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBanco
{
    public abstract class CuentaBancaria
    {
        protected int numero { get; set; }
        protected double saldo { get; set; }
        public CuentaBancaria(int Numero, double Saldo)
        {
            this.numero = Numero;
            this.saldo = Saldo;
        }
        public abstract double Depositar();
        public abstract double Retirar();
    }
}
