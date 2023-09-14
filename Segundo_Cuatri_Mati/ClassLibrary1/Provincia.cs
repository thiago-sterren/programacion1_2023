using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Provincia
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public Pais pais { get; set; }
        public Provincia(string Nombre, int ID, Pais Pais_)
        {
            this.nombre = Nombre;
            this.id = ID;
            this.pais = Pais_;
        }
        public static List<Localidad> lista_localidades = new List<Localidad>();
        public static List<Localidad> ObtenerListaLocalidades()
        {
            return lista_localidades;
        }
    }
}
