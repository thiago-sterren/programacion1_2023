using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBiblioteca
{
    public abstract class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anioPublicacion { get; set; }
        public bool disponible { get; set; } = true;
        public Libro(string Titulo, string Autor, int AnioPublicacion, bool Disponible)
        {
            this.titulo = Titulo;
            this.autor = Autor;
            this.anioPublicacion = AnioPublicacion;
            this.disponible = Disponible;
        }

        public abstract string ObtenerInformacion();
    }
}
