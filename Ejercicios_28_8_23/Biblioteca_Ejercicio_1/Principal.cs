using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Ejercicio_1
{
    public class Principal
    {
        public List<MotoDeportiva> motos_d = new List<MotoDeportiva>();
        public List<MotoUtilitaria> motos_u = new List<MotoUtilitaria>();
        public void AgregarMotoDeportiva(MotoDeportiva MD)
        {
            motos_d.Add(MD);
        }
        public void AgregarMotoUtilitaria(MotoUtilitaria MU)
        {
            motos_u.Add(MU);
        }
        public void BorrarMotoDeportiva(MotoDeportiva MD)
        {
            motos_d.Remove(MD);
        }
        public void BorrarMotoUtilitaria(MotoUtilitaria MU)
        {
            motos_u.Remove(MU);
        }
        public void ModificarMotoDeportiva(MotoDeportiva motoAEliminar, MotoDeportiva motoAAgregar)
        {
            motos_d.Remove(motoAEliminar);
            motos_d.Add(motoAAgregar);
        }
        public void ModificarMotoUtilitaria(MotoUtilitaria motoAEliminar, MotoUtilitaria motoAAgregar)
        {
            motos_u.Remove(motoAEliminar);
            motos_u.Add(motoAAgregar);
        }
    }
}
