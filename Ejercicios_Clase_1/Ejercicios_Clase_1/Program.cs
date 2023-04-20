// See https://aka.ms/new-console-template for more information

// REPASO 1

// EJERCICIOS CON DO WHILE:

/* 1- Para el ingreso a un sistema se necesita solicitar la clave,
// repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788
//Ejercicio hecho con while():
Console.WriteLine("Ingrese su clave:");
string? clave = Console.ReadLine();
while (clave != "667788")
{
    Console.WriteLine("Esa no es la clave, pruebe nuevamente:");
    clave = Console.ReadLine();
}
Console.WriteLine("Perfecto, ha ingresado correctamente");
*/

/* Ejercicio hecho con do{} while(): (sirve para economizar codigo y hacer las cosas mas prolijas)
Console.WriteLine("Ingrese su clave:");
string? clave;
do
{
    clave = Console.ReadLine();
} while (clave != "667788");
Console.WriteLine("Perfecto, ha ingresado correctamente");
*/

/* 2- Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que ingrese un positivo
Console.WriteLine("Inserte un numero positivo");
string? num;
double num_double;
do
{
    num = Console.ReadLine();
    num_double = double.Parse(num);
} while (num_double <= 0);
Console.WriteLine("Correcto, ingreso un positivo");
*/

/* 3- Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de los números negativos ingresados
Console.WriteLine("Inserte un numero positivo");
string? num;
double num_double;
double suma_negs = 0;
int cant_negs = 0;
do
{
    num = Console.ReadLine();
    num_double = double.Parse(num);
    if (num_double < 0)
    {
        suma_negs += num_double;
        cant_negs++;
    }
} while (num_double <= 0);
Console.WriteLine("Correcto, ingreso un positivo");
double promedio = suma_negs / cant_negs;
Console.WriteLine("El promedio de los numeros negativos ingresados es de: " + promedio);
*/

/* 4- Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese un número mayor a 3 cifras
Console.WriteLine("Ingrese un numero con mas de 3 cifras:");
string? num;
double num_double;
do
{
    num = Console.ReadLine();
    num_double = double.Parse(num);
} while (num_double < 1000);
Console.WriteLine("Perfecto, ingresaste un numero de 4 cifras o mas");
*/

/* 5- Siguiendo con el ejercicio anterior, al ingresar uno menor a 3 cifras se mostrará el promedio de los ingresados
Console.WriteLine("Ingrese un numero con mas de 3 cifras:");
string? num;
double num_double;
double suma = 0;
int cant_ingresados = 0;
double promedio = 0;
do
{
    num = Console.ReadLine();
    num_double = double.Parse(num);
    suma += num_double;
    cant_ingresados++;
    promedio = suma / cant_ingresados;
    if (num_double < 100)
    {
        Console.WriteLine("El promedio es de: " + promedio);
    }
} while (num_double < 1000);
Console.WriteLine("Perfecto, ingresaste un numero de 4 cifras o mas");
*/

// EJERCICIOS CON WHILE:

/* 1 y 2-
Console.WriteLine("Inserte los valores de sus ventas, cuando esten todos los valores ingresados, ponga 0 o un numero menor: ");
string valor = Console.ReadLine();
double valor_double = double.Parse(valor);
double suma = 0;
int cantidad_numeros = 0;
while (valor_double > 0)
{
    suma += valor_double;
    Console.WriteLine("La suma hasta el momento es de: " + suma);
    Console.WriteLine("Ingresar valor: ");
    valor = Console.ReadLine();
    valor_double = double.Parse(valor);
    cantidad_numeros++;
}
Console.WriteLine("La suma final es de: " + suma);
double promedio = suma / cantidad_numeros;
Console.WriteLine("El promedio es de: " + promedio);
*/

/* 3- El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío, sin datos; el sistema informará cuántos nombres se han ingresado.
Console.WriteLine("Ingrese nombres que se guardaran en una lista, cuando haya finalizado, ingrese un dato vacio");
List<string> nombres = new List<string>();
string nombre = Console.ReadLine();
int cantidad_nombres = 0;
nombres.Add(nombre);
while (nombre != "")
{
    Console.WriteLine("Ingrese un nombre:");
    nombre = Console.ReadLine();
    nombres.Add(nombre);
    cantidad_nombres++;
}
Console.WriteLine("La cantidad de nombres ingresados es: " + cantidad_nombres);
*/

/* 4- Para calcular el total de una factura, el usuario ingresará pares de datos Costo y Total ; cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado.
Console.WriteLine("Se le pediran pares de datos costo y total, acordes a los datos de su factura. Cuando haya finalizado, ingrese 0 en una peticion de costo");
Dictionary<double, double> costos_totales = new Dictionary<double, double>();
Console.WriteLine("Ingrese el costo:");
double costo = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el total:");
double total = double.Parse(Console.ReadLine());
costos_totales.Add(costo, total);
double total_adeudado = total;
while (costo != 0)
{
    Console.WriteLine("Ingrese el costo:");
    costo = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el total:");
    total = double.Parse(Console.ReadLine());
    costos_totales.Add(costo, total);
    total_adeudado += total;
}
Console.WriteLine("El total adeudado es: " + total_adeudado);
*/

/* 5- (es mas para un for) Para calcular el consumo total de un cliente, el usuario primero ingresará cuántos productos compró; luego el sistema solicitará que ingrese el total y costo de cada uno de esos productos consumidos; al terminar informará el total adeudado por el cliente. 
Console.WriteLine("Cuantos productos compró?");
string? cant_prod = Console.ReadLine();
int cant_prod_int = int.Parse(cant_prod);
double suma = 0;
for (int i = 1; i <= cant_prod_int; i++)
{
    Console.WriteLine("Costo unitario del producto:");
    string? costo_prod = Console.ReadLine();
    double costo_prod_double = double.Parse(costo_prod); // por lo que entendi, el enunciado pide que consultemos este dato, pero luego no debe ser utilizado en ningun momento
    Console.WriteLine("Total gastado en este producto:");
    string? total_prod = Console.ReadLine();
    double total_prod_double = double.Parse(total_prod);
    suma += total_prod_double;
}
Console.WriteLine("El total adeudado es de " + suma + ", mientras que la cantidad de productos comprados es de " + cant_prod_int);
*/

// EJERCICIOS CON FOR:

/* 1- El usuario necesita ingresar 5 valores enteros, el sistema deberá informar la suma de los 5
Console.WriteLine("A continuacion se le pediran 5 numeros enteros, para ser sumados posteriormente");
int suma = 0;
string? num;
int num_int;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese un numero entero:");
    num = Console.ReadLine();
    num_int = int.Parse(num);
    suma += num_int;
}
Console.WriteLine("La suma total de los 5 numeros es: " + suma);
*/

/* 2- Se necesita calcular el promedio de 8 números ingresados por el usuario
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Se le pediran 8 numeros para luego sacar un promedio");
int suma = 0;
string? num;
int num_int;
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Ingrese un numero: ");
    num = Console.ReadLine();
    num_int = int.Parse(num);
    suma += num_int;
}
int promedio = suma / 8;
Console.WriteLine("El promedio es de: " + promedio);
*/

/* 3- Para calcular el total de una factura , el usuario ingresará pares de datos Costo y Total ; de unas 5 compras; informar el total adeudado
double suma = 0;
string? costo;
double costo_double;
string? total;
double total_double;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese el costo unitario del producto: ");
    costo = Console.ReadLine();
    costo_double = double.Parse(costo);
    Console.WriteLine("Ingrese el total gastado en este producto: ");
    total = Console.ReadLine();
    total_double = double.Parse(total);
    suma += total_double;
}
Console.WriteLine("El total adeudado es de: " + suma);
*/

/* 4- De una lista de 8 números indicar cual es el mayor (este lo hice sin crear listas porque no sabia como)
int mayor = 0;
string? num;
int num_int;
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Ingrese un numero");
    num = Console.ReadLine();
    num_int = int.Parse(num);
    if (num_int > mayor)
    {
        mayor = num_int;
    }
}
Console.WriteLine("El mayor es: " + mayor);
*/

/* (este es el mismo 4 pero hecho con listas)
Console.WriteLine("Se le pediran 8 numeros enteros para conformar una lista y al final se devolvera el mayor");
List<int> numeros = new List<int>();
for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("Ingrese un numero entero:");
    int numero = int.Parse(Console.ReadLine());
    numeros.Add(numero);
}
int mayor = numeros.Max();
Console.WriteLine("El mayor es: " + mayor);
*/

/* 5- El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado, indicar el cliente que gastó más
Dictionary<string, double> datos = new Dictionary<string, double>();
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese su nombre:");
    string? nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el total gastado:");
    double total = double.Parse(Console.ReadLine());
    datos.Add(nombre, total);
}
double mayor_valor = 0;
string? nombre_del_mayor = null;
foreach (KeyValuePair<string, double> par in datos)
{
    if (par.Value > mayor_valor)
    {
        mayor_valor = par.Value;
        nombre_del_mayor = par.Key;
    }
}
Console.WriteLine("Quien mas gasto es " + nombre_del_mayor + ", con un total gastado de " + mayor_valor);
*/

// REPASO 2

/* 1- Se ingresa el código de producto (son 10 productos, codificados del 1 al 10),
// luego el precio y la cantidad que hay del mismo. La carga finaliza cuando se ingresa un
// código = 0 ; al terminar indicar el código de producto que mayor cantidad tiene.
Console.WriteLine("Puede cargar datos de hasta 10 productos distintos, cada uno con un codigo correspondiente entre 1 y 10. Si desea finalizar la carga antes, inserte como codigo un numero fuera de ese rango.");
int codigo;
double precio;
int cantidad;
int mayor_cantidad = 0;
int codigo_mayor_cantidad = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Ingrese el codigo del producto:");
    codigo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el precio del producto:");
    precio = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad que hay de este producto:");
    cantidad = int.Parse(Console.ReadLine());
    if (codigo <= 0 || codigo > 10) // lo hice para que si el numero que inserte no este entre 1-10, corte el codigo, y no solo con un 0
    {
        break;
    }
    if (cantidad > mayor_cantidad)
    {
        mayor_cantidad = cantidad;
        codigo_mayor_cantidad = codigo;
    }
}
Console.WriteLine("El codigo del producto con mayor cantidad es: " + codigo_mayor_cantidad);
*/

/* 2- Retomando el ejercicio 1 ; al finalizar la carga de productos, se ingresan las ventas que
// hubo por cada código, puede haber más de 1 venta por cada articulo. El ingreso finaliza al
// colocar un código en 0.  Informar al final los que tienen una cantidad
// (o sea la cantidad inicial , restando las ventas que tuvo) menor o igual a 0.
Console.WriteLine("Puede cargar datos de hasta 10 productos distintos, cada uno con un codigo correspondiente entre 1 y 10. Si desea finalizar la carga antes, inserte como codigo un numero fuera de ese rango.");
int codigo;
double precio;
int cantidad;
int mayor_cantidad = 0;
int codigo_mayor_cantidad = 0;
int ventas;
int cantidad_restante;
List<int> sobreventas = new List<int>();
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Ingrese el codigo del producto:");
    codigo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el precio del producto:");
    precio = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad que hay de este producto:");
    cantidad = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de ventas de este producto:");
    ventas = int.Parse(Console.ReadLine());
    cantidad_restante = cantidad - ventas;
    if (codigo <= 0 || codigo > 10) // lo hice para que si el numero que inserte no este entre 1-10, corte el codigo, y no solo con un 0
    {
        break;
    }
    if (cantidad_restante > mayor_cantidad)
    {
        mayor_cantidad = cantidad_restante;
        codigo_mayor_cantidad = codigo;
    }
    if (cantidad_restante <= 0)
    {
        sobreventas.Add(codigo);
    }
}
Console.WriteLine("El codigo del producto con mayor cantidad es: " + codigo_mayor_cantidad);
Console.WriteLine("Los codigos de los productos sobrevendidos son:");
foreach (int i in sobreventas)
{
    Console.WriteLine(i);
}
*/

/* 3- Retomando el ejercicio anterior, a continuación se colocan los nombres para cada código
// de producto, (opcional si la carga se realiza del 1 al 10 sin pedir el código o si se ingresa
// el código y luego la descripción del mismo) ; al finalizar la carga de los 10 códigos indicar
// el nombre de los productos que tuvieron un total de ventas menor a 10 unidades.
Console.WriteLine("Puede cargar datos de hasta 10 productos distintos, con codigos entre 1 y 10. Si desea finalizar la carga antes, inserte como codigo del producto un numero fuera de ese rango");
int codigo;
string? nombre;
double precio;
int cantidad;
int ventas;
List<string> ventas_menores_10 = new List<string>();
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Ingrese el codigo del producto:");
    codigo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el nombre del producto:");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el precio del producto:");
    precio = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad que hay de este producto:");
    cantidad = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de ventas de este producto:");
    ventas = int.Parse(Console.ReadLine());
    if (codigo <= 0 || codigo > 10)
    {
        break;
    }
    if (ventas < 10)
    {
        ventas_menores_10.Add(nombre);
    }
}
Console.WriteLine("Los productos con menos de 10 ventas son:");
foreach (string i in  ventas_menores_10)
{
    Console.WriteLine(i);
}
*/