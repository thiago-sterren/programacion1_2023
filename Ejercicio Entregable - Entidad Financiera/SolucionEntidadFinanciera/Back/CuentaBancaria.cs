using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class CuentaBancaria
    {
        public int id { get; set; }
        public string numeroCuenta { get; set; }
        public double saldo { get; set; }
        public enum Tipo
        {
            Corriente, Ahorro
        }
        public Tipo tipo { get; set; }
        public Cliente idClienteTitular { get; set; }
    }
}
