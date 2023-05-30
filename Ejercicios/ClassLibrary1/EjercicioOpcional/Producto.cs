using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Producto
    {
        public string nombre { get; set; }
        public double precio { get; set; }
        public Producto(string Nombre, double Precio)
        {
            nombre = Nombre;
            precio = Precio;
        }
        public abstract double CalcularImpuesto();
        public abstract double CalcularTotal();
    }
}
