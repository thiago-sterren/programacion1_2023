using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPedidos
{
    public class Principal
    {
        public List<PedidoLocal> lista_pedidos_locales = new List<PedidoLocal>();
        public List<PedidoOnline> lista_pedidos_online = new List<PedidoOnline>();
        public void altaPedidoLocal(PedidoLocal pedido_local)
        {
            lista_pedidos_locales.Add(pedido_local);
        }
        public void altaPedidoOnline(PedidoOnline pedido_online)
        {
            lista_pedidos_online.Add(pedido_online);
        }
    }
}
