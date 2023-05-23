using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Perro : Animal
    {
        public override string HacerSonido() // esta sobreescribiendo este metodo de la clase madre, por eso el override
        {
            return "Guau";
        }
    }
}
