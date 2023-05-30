using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ProductoDigital : Producto
    {
        public double tamanio { get; set; }
        public ProductoDigital(string Nombre, double Precio, double Tamanio) : base(Nombre, Precio)
        {
            tamanio = Tamanio;
        }
        public override double CalcularImpuesto()
        {
            return precio / 100 * 5;
        }
        public override double CalcularTotal()
        {
            return precio + CalcularImpuesto();
        }
    }
}
