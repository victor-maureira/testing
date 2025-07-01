using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tarea8Parte2
{
    internal class Program
    {
        /*Crear un programa que simule una app bancaria sencilla, y que nos permita tres cosas:

            Ingresar un gasto

            Mostrarnos todos los gastos que hemos hecho, empezando por el último

            Sumar todos los gastos hechos y mostrarnos el monto que debemos pagar (pago para no generar intereses)*/

        static void Main(string[] args)
        {
            int opcion;
            long gasto;

            //instancio el stack<t>

            Stack<long> appBanco = new Stack<long>();




            do
            {
                Console.Clear();

                Console.WriteLine("1. Ingresar un gasto");
                Console.WriteLine("2. Mostrar gastos");
                Console.WriteLine("3. Sumar gastos e indicar monto a pagar");
                
                Console.Write("\nIngrese una opción:");

                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                switch (opcion)
                {
                    case 1:

                        Console.Write("Ingrese el gasto: $");
                        gasto = Convert.ToInt64(Console.ReadLine());

                        appBanco.Push(gasto);

                        Console.WriteLine("El gasto se ha ingresado correctamente.");

                        Console.ReadKey();

                        break;


                    case 2:

                        Console.WriteLine("\n Gastos:");

                        foreach(long gastoAcumulado in appBanco)
                        {
                            Console.WriteLine(gastoAcumulado);
                        }
                        
                        
                        Console.WriteLine("\nPulse cualquier tecla para volver.");
                        Console.ReadKey();

                        break;


                    case 3:

                        long total = 0;
                        foreach (long gastoAcumulado in appBanco)
                        {
                            total += gastoAcumulado;
                        }

                        Console.WriteLine($"El gasto total es: ${total}");




                        Console.WriteLine("\nPulse cualquier tecla para volver.");
                        Console.ReadKey();

                        break;






                }


            } while (opcion >= 1 && opcion <= 3);

        }
    }
}
