using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_n3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //parte 1: programa que le pida al usuario un numero entre 1 y 12 y devuelva el nombre del mes correspondiente, agregar un case default.
            /*
            int mes;
            

            Console.WriteLine("Ingrese un número entre 1 y 12 para obtener el nombre del mes correspondiente:");
            mes = Convert.ToInt32(Console.ReadLine());

            switch(mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Número inválido. Por favor, ingrese un número entre 1 y 12.");
                    break;
            }
            */

            // Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.

           /* int numero;

            Console.WriteLine("Ingrese un número para verificar si es par o impar:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero}  es impar.");
            }
           */
            // Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00

            int minEst;

            Console.Write("Ingrese el tiempo en minutos que ha permanecido en el estacionamiento: ");
            minEst = Convert.ToInt32(Console.ReadLine());

            if (minEst >= 1 && minEst <= 60)
            {
                Console.WriteLine("El precio a pagar es de $5.00");
            }
            else if (minEst >= 61 && minEst <= 120)
            {
                Console.WriteLine("El precio a pagar es de $15.00");
            }
            else if (minEst > 120)
            {
                Console.WriteLine("El precio a pagar es de $40.00");
            }
            else
            {
                Console.WriteLine("Tiempo inválido. Por favor, ingrese un número positivo de minutos.");
            }



        }
    }
}
