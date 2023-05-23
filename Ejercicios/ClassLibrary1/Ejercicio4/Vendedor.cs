using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vendedor : Empleado
    {
        public override double CalcularSalario()
        {
            return horas_mensuales * 1000;
        }
    }
}
