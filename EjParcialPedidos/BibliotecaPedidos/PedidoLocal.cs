using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPedidos
{
    public class PedidoLocal : Pedido
    {
        public string sucursal { get; set; }
        public PedidoLocal(int Numero, DateTime Fecha, double Precio, string Sucursal) : base(Numero, Fecha, Precio)
        {
            this.sucursal = Sucursal;
        }
        public override double CalcularTotal()
        {
            return precio + precio * 0.05; // se cobra el 5% mas por ser pedido local
        }
        public override string MostrarDetalles()
        {
            return $"Se ha cargado el pedido numero {numero} para retirar el dia {fecha} en la sucursal de {sucursal}. El total a pagar es de {CalcularTotal()}";
        }
        public string InfoPL
        {
            get { return $"Pedido Local. Numero pedido: {numero}. Fecha de retiro: {fecha}. Sucursal: {sucursal}. Total a pagar: {CalcularTotal()}."; }
        }
    }
}
