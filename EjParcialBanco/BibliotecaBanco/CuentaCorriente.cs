using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBanco
{
    public class CuentaCorriente : CuentaBancaria
    {
        public double limiteSobregiro { get; set; }
        public CuentaCorriente(int Numero, double Saldo, double LimiteSobregiro) : base(Numero, Saldo)
        {
            this.limiteSobregiro = LimiteSobregiro;
        }
        public override double Depositar()
        {
            
        }
    }
}
