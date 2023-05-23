using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*Perro nuevo_perro = new Perro();
            nuevo_perro.nombre = "Rodo";
            Console.WriteLine("El nombre de su animal es:" + nuevo_perro.nombre);
            Console.WriteLine("Este animal hace el siguiente sonido:" + nuevo_perro.HacerSonido());

            Gato nuevo_gato = new Gato();
            nuevo_gato.nombre = "Michi";
            Console.WriteLine("El nombre de su animal es:" + nuevo_gato.nombre);
            Console.WriteLine("Este animal hace el siguiente sonido:" + nuevo_gato.HacerSonido());
            
            // este console.readline es innecesario para el codigo,
            // pero lo hago para que no se me cierre la consola al termino de la ejecucion del codigo de arriba
            Console.ReadLine();

            Circulo nuevo_circulo = new Circulo();
            Console.WriteLine("Escriba el radio de su circulo:");
            nuevo_circulo.radio = double.Parse(Console.ReadLine());
            Console.WriteLine($"El area de su circulo es de {nuevo_circulo.CalcularArea()}");

            Cuadrado nuevo_cuadrado = new Cuadrado();
            Console.WriteLine("Escriba la longitud de los lados del cuadrado:");
            nuevo_cuadrado.lado = double.Parse(Console.ReadLine());
            Console.WriteLine($"El area de su cuadrado es de {nuevo_cuadrado.CalcularArea()}");
            Console.ReadLine();*/
        }
    }
}