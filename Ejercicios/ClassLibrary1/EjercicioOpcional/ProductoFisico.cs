using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ProductoFisico : Producto
    {
        public double peso { get; set; }
        public ProductoFisico(string Nombre, double Precio, double Peso) : base(Nombre, Precio)
        {
            peso = Peso;
        }
        public override double CalcularImpuesto()
        {
            return precio / 100 * 10;
        }
        public override double CalcularTotal()
        {
            return precio + CalcularImpuesto();
        }
    }
}
