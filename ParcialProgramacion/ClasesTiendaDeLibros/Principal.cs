using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTiendaDeLibros
{
    public class Principal
    {
        public List<Libro> lista_libros = new List<Libro>();
        public void AltaLibro(Libro libro)
        {
            lista_libros.Add(libro);
        }
        public void BajaLibro(Libro libro)
        {
            lista_libros.Remove(libro);
        }
    }
}
