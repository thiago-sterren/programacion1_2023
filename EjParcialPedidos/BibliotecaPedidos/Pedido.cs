using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPedidos
{
    public abstract class Pedido
    {
        protected int numero { get; set; }
        protected DateTime fecha { get; set; }
        protected double precio { get; set; }
        public Pedido(int Numero, DateTime Fecha, double Precio)
        {
            this.numero = Numero;
            this.fecha = Fecha;
            this.precio = Precio;
        }
        public abstract double CalcularTotal();
        public abstract string MostrarDetalles();
    }
}
