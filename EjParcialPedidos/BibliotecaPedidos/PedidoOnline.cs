using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPedidos
{
    public class PedidoOnline : Pedido
    {
        public string direccionEnvio { get; set; }
        public PedidoOnline(int Numero, DateTime Fecha, double Precio, string DireccionEnvio) : base(Numero, Fecha, Precio)
        {
            this.direccionEnvio = DireccionEnvio;
        }
        public override double CalcularTotal()
        {
            return precio + precio * 0.1; // se cobra el 10% mas por ser pedido online
        }
        public override string MostrarDetalles()
        {
            return $"Se ha cargado el pedido numero {numero} para entregar el dia {fecha} en {direccionEnvio}. El total a pagar es de {CalcularTotal()}";
        }
        public string InfoPO
        {
            get { return $"Pedido Online. Numero pedido: {numero}. Fecha de entrega: {fecha}. Direccion de entrega: {direccionEnvio}. Total a pagar: {CalcularTotal()}."; }
        }
    }
}
