using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBiblioteca
{
    public class Principal
    {
        public List<Libro> lista_libros = new List<Libro>();
        public List<Cliente> lista_clientes = new List<Cliente>();
        public List<Prestamo> lista_prestamos = new List<Prestamo>();
        public void altaLibro(Libro libro)
        {
            lista_libros.Add(libro);
        }
        public void altaCliente(Cliente cliente)
        {
            lista_clientes.Add(cliente);
        }
        public void altaPrestamo(Prestamo prestamo)
        {
            lista_prestamos.Add(prestamo);
        }
    }
}
