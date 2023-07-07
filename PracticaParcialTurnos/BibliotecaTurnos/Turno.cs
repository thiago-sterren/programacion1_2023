using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTurnos
{
    public abstract class Turno
    {
        protected DateTime fecha { get; set; }
        protected int duracion { get; set; }
        public Turno(DateTime Fecha, int Duracion)
        {
            this.fecha = Fecha;
            this.duracion = Duracion;
        }
        public abstract double CalcularCosto();
        public abstract string MostrarInformacion();
    }
}
