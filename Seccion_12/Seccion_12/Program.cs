using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_12
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int opcion;
        //    int a = 5, b = 10;
        //    do
        //    {
        //        Console.WriteLine("1. Sumar");
        //        Console.WriteLine("2. Restar");

        //        Console.WriteLine("Seleccione una Opcion");
        //        try
        //        {
        //            opcion = Convert.ToInt32(Console.ReadLine());
        //        }
        //        catch (FormatException e)
        //        {
        //            Console.WriteLine("Formato no valido. Ingrese un numero (1 o 2)");
        //            opcion = 5;
        //        }
        //        catch (OverflowException e)
        //        {
        //            Console.WriteLine("Numero demasiado grande. Ingrese un numero (1 o 2)");
        //            opcion = 5;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Algo ha salido mal. Ingresa un numero (1 o 2)");
        //            opcion = 5;
        //        }


        //        switch (opcion)
        //        {
        //            case 1:
        //                Console.WriteLine($"Suma: {a + b}");
        //                break;

        //            case 2:
        //                Console.WriteLine($"Resta: {a - b}");
        //                break;

        //            default:
        //                break;
        //        }





        //    } while (opcion != 1 && opcion != 2);
        //}


        static void Main(string[] args)
        {
            int edad = 15;
            string resultado;

            resultado = edad >= 18 ? "Mayor de edad" : "Menor de edad";
            Console.WriteLine($"Es: {resultado}");
 

        }


       
        
    }
}