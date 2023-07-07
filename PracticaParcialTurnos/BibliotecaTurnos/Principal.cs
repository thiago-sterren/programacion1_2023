using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTurnos
{
    public class Principal
    {
        public List<TurnoPresencial> lista_turnos_presenciales = new List<TurnoPresencial>();
        public List<TurnoVirtual> lista_turnos_virtuales = new List<TurnoVirtual>();
        public void altaTurnoPresencial(TurnoPresencial turno_presencial)
        {
            lista_turnos_presenciales.Add(turno_presencial);
        }
        public void altaTurnoVirtual(TurnoVirtual turno_virtual)
        {
            lista_turnos_virtuales.Add(turno_virtual);
        }
    }
}
