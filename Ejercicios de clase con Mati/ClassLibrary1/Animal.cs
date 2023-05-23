using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Animal
    {
        public string nombre { get; set; }
        public string dueno { get; set; }
        public DateTime nacimiento { get; set; }
        public abstract string HacerSonido(); // un animal x no hara sonido, pero un animal caracterizado (perro o gato)
                                              // si lo hara, entonces lo hacemos para que las clases hijas lo hereden y no
                                              // sea necesario escribir el codigo de nuevo
    }
}
