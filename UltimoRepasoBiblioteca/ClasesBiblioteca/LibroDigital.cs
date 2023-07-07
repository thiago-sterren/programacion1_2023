using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBiblioteca
{
    public class LibroDigital : Libro
    {
        public double tamanoArchivo { get; set; }
        public string formato { get; set; }
        public LibroDigital(string Titulo, string Autor, int AnioPublicacion, bool Disponible, double TamanoArchivo, string Formato) : base(Titulo, Autor, AnioPublicacion, Disponible)
        {
            this.tamanoArchivo = TamanoArchivo;
            this.formato = Formato;
        }
        public override string ObtenerInformacion()
        {
            return $"Se ha agregado a la lista el libro digital '{titulo}' de {autor} del anio {anioPublicacion}. Ocupa {tamanoArchivo}MB y usa un formato de {formato}.";
        }
        public string InfoParaElListBoxLibroDigital
        {
            get { return $"Tipo: digital. Titulo: {titulo}. Autor: {autor}. Anio de publicacion: {anioPublicacion}. Tamanio del archivo: {tamanoArchivo}. Formato: {formato}."; }
        }
    }
}
