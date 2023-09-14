using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        public List<Cliente> ListaClientes = new List<Cliente>();
        public List<Prestamo> ListaPrestamos = new List<Prestamo>();
        public List<Libro> ListaLibros = new List<Libro>();
        public List<Copia> ListaCopias = new List<Copia>();

        public void AltaCliente (Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }
        public void BajaCliente(Cliente cliente)
        {
            ListaClientes.Remove(cliente);
        }
        public void ModificacionCliente(Cliente clienteAEliminar, Cliente clienteNuevo)
        {
            ListaClientes.Remove(clienteAEliminar);
            ListaClientes.Add(clienteNuevo);
        }
    }
}
