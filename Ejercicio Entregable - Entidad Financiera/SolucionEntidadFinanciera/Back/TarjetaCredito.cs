using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class TarjetaCredito
    {
        public int id { get; set; }
        public int numeroTarjeta { get; set; }
        public double limiteCredito { get; set; }
        public double saldoDisponible { get; set; }
        public string estado { get; set; }
        public TarjetaCredito(int numeroTarjeta, double limiteCredito, double saldoDisponible, string estado)
        {
            this.numeroTarjeta = numeroTarjeta;
            this.limiteCredito = limiteCredito;
            this.saldoDisponible = saldoDisponible;
            this.estado = estado;
        }
    }
}
