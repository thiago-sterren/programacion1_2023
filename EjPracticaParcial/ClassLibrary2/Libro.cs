using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public abstract class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anioPublicacion { get; set; }
        public bool disponible { get; set; } = true;
        public Libro(string Titulo, string Autor, int AnioPublicacion, bool Disponible)
        {
            titulo = Titulo;
            autor = Autor;
            anioPublicacion = AnioPublicacion;
            disponible = Disponible;
        }
        public abstract string ObtenerInformacion();
    }
}
