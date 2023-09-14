using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Ejercicio_1
{
    public abstract class Moto
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public abstract string RealizarMantenimiento();
        public Moto(int ID, string Marca, string Modelo)
        {
            this.id = ID;
            this.marca = Marca;
            this.modelo = Modelo;
        }
    }
}
