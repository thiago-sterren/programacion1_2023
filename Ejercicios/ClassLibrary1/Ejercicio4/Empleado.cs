using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int horas_mensuales { get; set; }
        public abstract double CalcularSalario();
    }
}
