using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Prestamo
    {
        public Cliente clientePrestamo { get; set; }
        public Libro libroPrestamo { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public DateTime fechaDevolucion { get; set; }
    }
}
