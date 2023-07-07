using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaBiblioteca
{
    public class Principal
    {
        public List<Libro> lista_libros = new List<Libro>();
        public List<Cliente> lista_clientes = new List<Cliente>();
        public List<Prestamo> lista_prestamos = new List<Prestamo>();
        public void altaLibro(Libro libro_nuevo)
        {
            lista_libros.Add(libro_nuevo);
        }
        public void altaCliente(Cliente cliente_nuevo)
        {
            lista_clientes.Add(cliente_nuevo);
        }
        public void altaPrestamo(Prestamo prestamo_nuevo)
        {
            lista_prestamos.Add(prestamo_nuevo);
        }
        public void bajaPrestamo(Prestamo bajar_prestamo)
        {
            lista_prestamos.Remove(bajar_prestamo);
        }
    }
}