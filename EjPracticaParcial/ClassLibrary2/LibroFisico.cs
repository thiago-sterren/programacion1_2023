using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class LibroFisico : Libro
    {
        public int numeroPaginas { get; set; }
        public LibroFisico(string Titulo, string Autor, int AnioPublicacion, bool Disponible, int NumeroPaginas) : base(Titulo, Autor, AnioPublicacion, Disponible)
        {
            numeroPaginas = NumeroPaginas;
        }
        public override string ObtenerInformacion()
        {
            return ($"El numero de paginas es {numeroPaginas}");
        }
    }
}
