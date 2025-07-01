using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Definición de variables
            int num1, num2, suma, resta, multiplicacion, division;
            string nombre;
            // Solicitar el nombre del usuario
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            // Solicitar los números al usuario
            Console.WriteLine("Hola " + nombre + ", ingrese el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());
            // Realizar las operaciones
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;
            // Mostrar los resultados
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicación es: " + multiplicacion);
            Console.WriteLine("La división es: " + division);
            // Esperar a que el usuario presione una tecla antes de cerrar la consola
            

            //Console.ReadKey();
        }
    }
}
