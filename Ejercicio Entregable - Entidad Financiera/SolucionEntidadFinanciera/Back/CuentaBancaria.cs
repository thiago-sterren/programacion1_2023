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
        public int numeroCuenta { get; set; }
        public double saldo { get; set; }
        public enum Tipo
        {
            Corriente, Ahorro
        }
        public Tipo tipo { get; set; }
        public Cliente idClienteTitular { get; set; }
        public CuentaBancaria(int numeroCuenta, double saldo, Tipo tipo, Cliente idClienteTitular)
        {
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.tipo = tipo;
            this.idClienteTitular = idClienteTitular;
        }
    }
}
