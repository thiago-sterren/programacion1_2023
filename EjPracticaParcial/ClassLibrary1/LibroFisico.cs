using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LibroFisico : Libro
    {
        public int numeroPaginas { get; set; }
        public override string ObtenerInformacion()
        {
            return $"El numero de paginas es {numeroPaginas}";
        }
    }
}
