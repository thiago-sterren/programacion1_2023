using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Ejercicio_1
{
    public class MotoDeportiva : Moto
    {
        public int cilindrada { get; set; }
        public MotoDeportiva(int ID, string Marca, string Modelo, int Cilindrada) : base(ID, Marca, Modelo)
        {
            this.cilindrada = Cilindrada;
        }
        public override string RealizarMantenimiento()
        {
            return "Se esta realizando mantenimiento a esta moto deportiva";
        }
    }
}
