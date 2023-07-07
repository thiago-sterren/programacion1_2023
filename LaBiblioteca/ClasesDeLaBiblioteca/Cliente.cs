using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaBiblioteca
{
    public class Cliente
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Cliente(int Dni, string Nombre, string Apellido)
        {
            dni = Dni;
            nombre = Nombre;
            apellido = Apellido;
        }
    }
}
