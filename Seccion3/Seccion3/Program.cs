using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Seccion3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //programa que pregunte al usuario cuatro opciones: sumar, restar, multiplicar y dividir.
            int opcion;
            decimal num1, num2, resultado = 0;

            Console.Write("Escoja una opción:\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\nOpción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción entre 1 y 4.");
                    break;
            }







        }

    }

}