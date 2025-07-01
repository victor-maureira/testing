using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hacer un programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente 
            /*   float  numBase, exponente, resultado = 1;

               Console.WriteLine("Ingrese la base: ");
               numBase = Convert.ToSingle(Console.ReadLine());

               Console.WriteLine("Ingrese el exponente: ");
               exponente = Convert.ToSingle(Console.ReadLine());

               if (exponente == 1)
               {
                   Console.WriteLine($"La potencia de {numBase} con exponente {exponente} es siempre igual a la base: {numBase}");
               }
               else if (exponente == 0)
               {
                   resultado = 1;
                   Console.WriteLine($"Toda potencia con exponente cero, su resultado siempre sérá: {resultado}");
               }
               else if (exponente < 0)
               {
                   resultado = 1;
                   for (int i = 1; i <= Math.Abs(exponente); i++)
                   {
                       resultado *= numBase;
                   }
                   resultado = 1 / resultado;
                   Console.WriteLine($"Exponente negativo: La potencia de {numBase} con exponente {exponente} es: {resultado}");
               }
               else
               {
                   for (int i = 1; i <= exponente; i++)
                   {
                       resultado *= numBase;

                   }

                   Console.WriteLine($"Exponente positivo, La potencia de {numBase} con exponente {exponente} es: {resultado}");
               }
    */

            // Hacer un programa que calcule los números primos que existen entre el 1 y el 100

            Console.WriteLine("Números primos del 1 al 100:");
            Console.WriteLine("Nota: El 1 no es primo.");

            for (int num = 2; num <= 100; num++)
            {
                bool esPrimo = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(num);
                }



            }
        }
    }

}