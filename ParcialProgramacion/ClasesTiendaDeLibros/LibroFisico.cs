using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTiendaDeLibros
{
    public class LibroFisico : Libro
    {
        public int nroPags { get; set; }
        public double peso { get; set; }
        public LibroFisico(string ISBN, string Titulo, string Autor, double Precio, int NroPags, double Peso) : base(ISBN, Titulo, Autor, Precio)
        {
            this.nroPags = NroPags;
            this.peso = Peso;
        }
    }
}
