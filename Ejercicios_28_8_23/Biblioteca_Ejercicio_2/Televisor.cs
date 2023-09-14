using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio_2
{
    public class Televisor : ProductoElectronico
    {
        public double tamanio_pantalla { get; set; }
        public Televisor(int ID, string Nombre, double Precio, double Tamanio_Pantalla) : base(ID, Nombre, Precio)
        {
            this.tamanio_pantalla = Tamanio_Pantalla;
        }
        public override double CalcularImpuesto()
        {
            return precio * 0.1;
        }
        public override double CalculaTotal()
        {
            return CalcularImpuesto() + precio;
        }
        public string texto
        {
            get { return $"Televisor: {nombre}. Precio con impuesto: {CalculaTotal()}."; }
        }
    }
}
