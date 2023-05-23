using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class FiguraGeometrica
    {
        public string nombre { get; set; }
        public string DecimeQuienSos()
        {
            return $"Hola me llamo {nombre} y mi area es {CalcularArea()}";
        }
        public abstract double CalcularArea();
    }
}
