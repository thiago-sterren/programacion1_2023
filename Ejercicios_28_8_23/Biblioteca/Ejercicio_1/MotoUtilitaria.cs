using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Ejercicio_1
{
    public class MotoUtilitaria : Moto
    {
        public string uso { get; set; }
        public MotoUtilitaria(int ID, string Marca, string Modelo, string Uso) : base(ID, Marca, Modelo)
        {
            this.uso = Uso;
        }
        public override string RealizarMantenimiento()
        {
            return "Se esta realizando mantenimiento a esta moto utilitaria";
        }
    }
}
