using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pais
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public Pais(string Nombre, int ID)
        {
            this.nombre = Nombre;
            this.id = ID;
        }
        public static List<Provincia> lista_provincias = new List<Provincia>();
        public static List<Provincia> ObtenerListaProvincias()
        {
            return lista_provincias;
        }
    }
}
