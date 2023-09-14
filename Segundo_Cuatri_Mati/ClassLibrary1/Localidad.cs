using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Localidad
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public string codigo_postal { get; set; }
        public Provincia provincia { get; set; }
        public Localidad(string Nombre, int ID, string CP, Provincia Provincia_)
        {
            this.nombre = Nombre;
            this.id = ID;
            this.codigo_postal = CP;
            this.provincia = Provincia_;
        }
        private static List<Localidad> lista_localidades = new List<Localidad>();
        public static List<Localidad> ObtenerListaLocalidades()
        {
            if(lista_localidades == null)
            {
                lista_localidades= new List<Localidad>();
                Localidad nueva_localidad = new Localidad("Sunchales", );
            }
        }
    }
}
