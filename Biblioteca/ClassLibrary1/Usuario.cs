using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Usuario
    {
        public string usuario_nombre { get; set; }
        public string usuario_contrasena { get; set; }
        public bool ValidarUsuario(string nombre_usuario, string contrasena_usuario)
        {
            if (usuario_nombre == nombre_usuario)
            {
                if (usuario_contrasena == contrasena_usuario)
                {
                    return true;
                }
                return false; // contrasena invalida
            }
            return false;
        }   
    }
}
