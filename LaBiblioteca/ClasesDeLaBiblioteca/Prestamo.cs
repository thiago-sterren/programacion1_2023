using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaBiblioteca
{
    public class Prestamo
    {
        public DateTime fechaPrestamo { get; set; }
        public DateTime? fechaDevolucion { get; set; }
        public Cliente clientePrestamo { get; set; }
        public Libro libroPrestamo { get; set; }
        public Prestamo(DateTime FechaPrestamo, DateTime FechaDevolucion, Cliente ClientePrestamo, Libro LibroPrestamo)
        {
            fechaPrestamo = FechaPrestamo;
            fechaDevolucion = FechaDevolucion;
            clientePrestamo = ClientePrestamo;
            libroPrestamo = LibroPrestamo;
        }
        public string InfoPrestamo
        {
            get { return $"Cliente {clientePrestamo.nombre} {clientePrestamo.apellido}. Libro: {libroPrestamo.titulo}. Fecha de inicio del prestamo: {fechaPrestamo}. Fecha de devolucion: {fechaDevolucion}."; }
        }
    }
}
