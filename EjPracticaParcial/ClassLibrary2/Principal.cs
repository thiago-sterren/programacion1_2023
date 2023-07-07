using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Principal
    {
        List <Libro> lista_libros = new List <Libro> ();
        List <Cliente> lista_clientes = new List <Cliente> ();
        List <Prestamo> lista_prestamos = new List <Prestamo> ();
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
        public void bajaLibro(Libro libro_borrado)
        {
            lista_libros.Remove(libro_borrado);
        }
        public void bajaCliente(Cliente cliente_borrado)
        {
            lista_clientes.Remove(cliente_borrado);
        }
        public void bajaPrestamo(Prestamo prestamo_borrado)
        {
            lista_prestamos.Remove(prestamo_borrado);
        }
    }
}
