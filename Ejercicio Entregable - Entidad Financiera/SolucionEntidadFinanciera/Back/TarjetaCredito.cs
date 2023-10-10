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
        public string numeroTarjeta { get; set; }
        public double limiteCredito { get; set; }
        public double saldoDisponible { get; set; }
        public enum Estado
        {
            Activa, Pausada, Bloqueada
        }
        public Estado estado { get; set; } = Estado.Activa;
        public double MontoDeuda { get; set; } = 0;
        public Cliente idClienteTitular { get; set; }
    }
}
