using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio_2
{
    public class Smartphone : ProductoElectronico
    {
        public double capacidad_almacenamiento { get; set; }
        public Smartphone(int ID, string Nombre, double Precio, double Capacidad_Almacenamiento) : base(ID, Nombre, Precio)
        {
            this.capacidad_almacenamiento = Capacidad_Almacenamiento;
        }
        public override double CalcularImpuesto()
        {
            return precio * 0.2;
        }
        public override double CalculaTotal()
        {
            return CalcularImpuesto() + precio;
        }
        public string texto
        {
            get { return $"Smartphone: {nombre}. Precio con impuesto: {CalculaTotal()}."; }
        }
    }
}
