using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTiendaDeLibros
{
    public class LibroDigital : Libro
    {
        public string formato { get; set; }
        public double tamanioArchivo { get; set; }
        public LibroDigital(string ISBN, string Titulo, string Autor, double Precio, string Formato, double TamanioArchivo) : base(ISBN, Titulo, Autor, Precio)
        {
            this.formato = Formato;
            this.tamanioArchivo = TamanioArchivo;
        }
    }
}
