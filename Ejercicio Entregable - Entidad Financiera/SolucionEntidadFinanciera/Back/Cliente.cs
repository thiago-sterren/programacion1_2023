using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public Cliente(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        public string info_list_box
        {
            get { return $"ID: {id}, {nombre} {apellido}"; }
        }
        public int cantidadCuentas { get; set; }
        public int cantidadTarjetas { get; set; }
    }
}
