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
            /*List <Empleado> lista_empleados = new List <Empleado> ();
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
            }*/
            /*List <InstrumentoMusical> lista_instrumentos = new List<InstrumentoMusical>();
            Bateria nueva_bateria = new Bateria();
            Guitarra nueva_guitarra = new Guitarra();
            Piano nuevo_piano = new Piano();
            lista_instrumentos.Add(nueva_bateria);
            lista_instrumentos.Add(nueva_guitarra);
            lista_instrumentos.Add(nuevo_piano);
            foreach (InstrumentoMusical instrumento in lista_instrumentos)
            {
                Console.WriteLine($"El sonido de este instrumento es: {instrumento.Tocar()}");
            }*/
            /*List <Producto> lista_productos = new List<Producto>();
            ProductoFisico nuevo_producto_fisico = new ProductoFisico("Monitor", 100000, 2);
            ProductoDigital nuevo_producto_digital = new ProductoDigital("MemoriaSD", 5000, 64000);
            lista_productos.Add(nuevo_producto_fisico);
            lista_productos.Add(nuevo_producto_digital);
            foreach (Producto producto in lista_productos)
            {
                Console.WriteLine($"El nombre de este producto es: {producto.nombre}");
                Console.WriteLine($"El precio inicial de este producto es: {producto.precio}");
                Console.WriteLine($"Su impuesto de venta es de: {producto.CalcularImpuesto()}");
                Console.WriteLine($"Por lo tanto, el total a pagar es: {producto.CalcularTotal()}");
            }*/
        }
    }
}
