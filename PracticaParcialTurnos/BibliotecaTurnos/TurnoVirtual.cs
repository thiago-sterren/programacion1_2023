using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTurnos
{
    public class TurnoVirtual : Turno
    {
        public string plataforma { get; set; }
        public TurnoVirtual(DateTime Fecha, int Duracion, string Plataforma) : base(Fecha, Duracion)
        {
            this.plataforma = Plataforma;
        }
        public override double CalcularCosto()
        {
            return duracion * 200; // suponiendo que cada minuto vale 200
        }
        public override string MostrarInformacion()
        {
            return $"Turno virtual de {duracion} minutos se hara el dia {fecha} por {plataforma}. Su costo es de {CalcularCosto()}";
        }
        public string InfoTV
        {
            get { return $"Dia: {fecha}. Duracion: {duracion}. Plataforma: {plataforma}. Costo: {CalcularCosto()}"; }
        }
    }
}
