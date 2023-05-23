using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Circulo : FiguraGeometrica
    {
        public double radio { get; set; }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio,2); // el primer parametro es elevado al segundo parametro
        }
    }
}
