using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio_2
{
    public abstract class ProductoElectronico
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public abstract double CalcularImpuesto();
        public abstract double CalculaTotal();
        public ProductoElectronico(int ID, string Nombre, double Precio)
        {
            this.id = ID;
            this.nombre = Nombre;
            this.precio = Precio;
        }
    }
}