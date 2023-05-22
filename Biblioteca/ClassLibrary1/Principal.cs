using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Principal
    {
        List<Cliente> lista_clientes = new List<Cliente>();
        List<Prestamo> lista_prestamos = new List<Prestamo>();
        List<Persona> lista_personas = new List<Persona>();
        List<Libro> lista_libros = new List<Libro>();
        List<Usuario> lista_usuarios = new List<Usuario>();
        // metodo que interactua con la lista de clientes
        public void AltaCliente(int dni, string nombre, string apellido, DateTime fecha_nacimiento, string nombre_usuario, string contrasena_usuario) // cree un metodo. void no me devuelve ningun valor, me sirve para dar la alta, o cuando no debo devolverle nada al usuario
        {
            Cliente cliente_nuevo= new Cliente();
            cliente_nuevo.id = cliente_nuevo.id + 1; // el + 1 lo hace autoincremental
            cliente_nuevo.dni = dni;
            cliente_nuevo.nombre = nombre;
            cliente_nuevo.apellido = apellido;
            cliente_nuevo.fecha_nacimiento = fecha_nacimiento;
            cliente_nuevo.usuario_cliente.usuario_nombre = nombre_usuario;
            cliente_nuevo.usuario_cliente.usuario_contrasena = contrasena_usuario;
            lista_clientes.Add(cliente_nuevo);
            lista_usuarios.Add(cliente_nuevo.usuario_cliente);
        }
        public void ModificarCliente(int id, Cliente cliente_nuevo)
        {
            Cliente clienteModificado = new Cliente();
            var clienteEncontrado = lista_clientes.Find(x => x.id == id);
            if (clienteEncontrado != null )
            {
                clienteModificado.dni = cliente_nuevo.dni;
                clienteModificado.nombre = cliente_nuevo.nombre;
                clienteModificado.apellido = cliente_nuevo.apellido;
                clienteModificado.fecha_nacimiento = cliente_nuevo.fecha_nacimiento;

                lista_clientes.Add(clienteModificado);
                lista_clientes.Remove(clienteEncontrado);
            }
        }
        public List<Cliente> MostrarLista()
        {
            return lista_clientes;
        }
    }
    /*public bool ValidarUsuario(string nombre, string contrasena)
    {
        Usuario usuario = new Usuario();

    }*/
}
