using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaClases;

namespace ProyectoConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Principal principal = new Principal();
            Usuario usuario = new Usuario();
            
            Cliente cliente_agregado = new Cliente();
            
            Console.WriteLine("Agrega una persona:");
            Console.WriteLine("Ingrese el DNI:");
            cliente_agregado.dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre:");
            cliente_agregado.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido:");
            cliente_agregado.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento:");
            cliente_agregado.fecha_nacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre de usuario que desee tener:");
            cliente_agregado.usuario_cliente.usuario_nombre = Console.ReadLine();
            Console.WriteLine("Ingrese una contraseña:");
            cliente_agregado.usuario_cliente.usuario_contrasena = Console.ReadLine();

            principal.AltaCliente(cliente_agregado.dni, cliente_agregado.nombre, cliente_agregado.apellido, cliente_agregado.fecha_nacimiento, cliente_agregado.usuario_cliente.usuario_nombre, cliente_agregado.usuario_cliente.usuario_contrasena);
        }
    }
}
