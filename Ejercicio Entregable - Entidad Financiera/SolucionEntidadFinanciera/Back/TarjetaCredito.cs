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
        public enum Estado
        {
            Activa, Pausada, Bloqueada
        }
        public Estado estado { get; set; } = Estado.Activa;
        public double MontoDeuda { get; set; }
        public Cliente idClienteTitular { get; set; }
        public TarjetaCredito(int numeroTarjeta, double limiteCredito, double saldoDisponible, Estado estado,  Cliente idClienteTitular)
        {
            this.numeroTarjeta = numeroTarjeta;
            this.limiteCredito = limiteCredito;
            this.saldoDisponible = saldoDisponible;
            this.estado = estado;
            this.idClienteTitular = idClienteTitular;
        }
    }
}
