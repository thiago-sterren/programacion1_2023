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
        public TarjetaCredito tarjetaCredito { get; set; }
        public Cliente clienteTitular { get; set; }
        public CuentaBancaria(int numeroCuenta, double saldo, Tipo tipo, TarjetaCredito tarjetaCredito, Cliente clienteTitular)
        {
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.tipo = tipo;
            this.tarjetaCredito = tarjetaCredito;
            this.clienteTitular = clienteTitular;
        }
    }
}
