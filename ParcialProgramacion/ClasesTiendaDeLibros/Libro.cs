using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTiendaDeLibros
{
    public abstract class Libro
    {
        public string isbn { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public double precio { get; set; }
        public Libro(string ISBN, string Titulo, string Autor, double Precio)
        {
            this.isbn = ISBN;
            this.titulo = Titulo;
            this.autor = Autor;
            this.precio = Precio;
        }
    }
}
