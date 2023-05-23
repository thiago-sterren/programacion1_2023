using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List <Vehiculo> lista_vehiculos = new List <Vehiculo> ();
            Auto nuevo_auto = new Auto ();
            lista_vehiculos.Add (nuevo_auto);

            Bicicleta nueva_bicicleta = new Bicicleta();
            lista_vehiculos.Add(nueva_bicicleta);

            foreach (Vehiculo vehiculo in lista_vehiculos)
            {
                Console.WriteLine($"El vehiculo acelero: {vehiculo.Acelerar()}");
            }*/
            List <Empleado> lista_empleados = new List <Empleado> ();
            Gerente nuevo_gerente = new Gerente ();
            nuevo_gerente.nombre = "Thiago";
            nuevo_gerente.apellido = "Sterren";
            nuevo_gerente.horas_mensuales = 200;
            lista_empleados.Add (nuevo_gerente);

            Vendedor nuevo_vendedor = new Vendedor ();
            nuevo_vendedor.nombre = "Juan";
            nuevo_vendedor.apellido = "Fernandez";
            nuevo_vendedor.horas_mensuales = 180;
            lista_empleados.Add (nuevo_vendedor);

            foreach (Empleado empleado in lista_empleados)
            {
                Console.WriteLine($"El sueldo de este empleado es de: {empleado.CalcularSalario()}");
            }
            Console.WriteLine("Hola");
        }
    }
}
