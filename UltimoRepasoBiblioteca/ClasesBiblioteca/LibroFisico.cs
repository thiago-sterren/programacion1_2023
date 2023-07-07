using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBiblioteca
{
    public class LibroFisico : Libro
    {
        public int numeroPaginas { get; set; }
        public LibroFisico(string Titulo, string Autor, int AnioPublicacion, bool Disponible, int NumeroPaginas) : base(Titulo, Autor, AnioPublicacion, Disponible)
        {
            this.numeroPaginas = NumeroPaginas;
        }
        public override string ObtenerInformacion()
        {
            return $"Se ha agregado a la lista el libro fisico '{titulo}' de {autor} del anio {anioPublicacion}. Tiene {numeroPaginas} paginas.";
        }
        public string InfoParaElListBoxLibroFisico
        {
            get { return $"Tipo: fisico. Titulo: {titulo}. Autor: {autor}. Anio de publicacion: {anioPublicacion}. Numero de paginas: {numeroPaginas}."; }
        }
    }
}
