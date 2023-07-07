using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LibroDigital : Libro
    {
        public int tamanoArchivo { get; set; }
        public string formato { get; set; }
        public override string ObtenerInformacion()
        {
            return $"El tamano del archivo es {tamanoArchivo}, y el formato {formato}";
        }
    }
}
