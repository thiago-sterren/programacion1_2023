using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaBiblioteca
{
    public class LibroDigital : Libro
    {
        public double tamanoArchivo { get; set; }
        public string formato { get; set; }
        public LibroDigital(string Titulo, string Autor, int AnioPublicacion, bool Disponible, double TamanoArchivo, string Formato) : base(Titulo, Autor, AnioPublicacion, Disponible)
        {
            tamanoArchivo = TamanoArchivo;
            formato = Formato;
        }
        public override string ObtenerInformacion()
        {
            return $"El tamanio de archivo es {tamanoArchivo} y el formato es {formato}";
        }
    }
}
