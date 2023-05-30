using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bateria : InstrumentoMusical
    {
        public override string Tocar()
        {
            return "bateria";
        }
    }
}
