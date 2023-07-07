using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTurnos
{
    public class TurnoPresencial : Turno
    {
        public string lugar { get; set; }
        public TurnoPresencial(DateTime Fecha, int Duracion, string Lugar) : base(Fecha, Duracion)
        {
            this.lugar = Lugar;
        }
        public override double CalcularCosto()
        {
            return duracion * 100; // suponiendo que cada minuto vale 100
        }
        public override string MostrarInformacion()
        {
            return $"Turno presencial de {duracion} minutos se hara el dia {fecha} en {lugar}. Su costo es de {CalcularCosto()}";
        }
        public string InfoTP
        {
            get { return $"Dia: {fecha}. Duracion: {duracion}. Lugar: {lugar}. Costo: {CalcularCosto()}."; }
        }
    }
}
