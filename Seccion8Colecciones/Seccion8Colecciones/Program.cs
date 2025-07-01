using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion8Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //stack

            Stack <double> miPila = new Stack <double> ();

            //insertar objetos al principio del stack
            miPila.Push(5.9);
            miPila.Push(13.1);
            miPila.Push(8.3);
            miPila.Push(9.7);
            miPila.Push(19.2);

            int i = 0; //indice

            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            //despues de quitar un elemento
            Console.WriteLine("Despues de quitar un elemento.");
           var eliminado = miPila.Pop();
            i = 0; //reiniciamos el indice

            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            Console.WriteLine($"El elemento {eliminado} ha sido eliminado.");

            //despues de usar peek
            Console.WriteLine("dESPUEs de usar peek");
            var primerObj = miPila.Peek();

            i = 0;

            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            Console.WriteLine($"el primer elemento del stack es: {primerObj}");



            //saber si el stack contiene un elemento

            bool contiene;
            double buscarElem;

            Console.WriteLine("\nIngresa el elemento a buscar: ");
            buscarElem = Convert.ToDouble(Console.ReadLine());

            contiene = miPila.Contains(buscarElem);

            if(contiene)
            {
                Console.WriteLine($"El objeto {buscarElem} se encuentra en el stack. \n");
            }
            else
            {
                Console.WriteLine($"El objeto {buscarElem} NO SE ENCONTRÓ en el stack. \n");
            }

            Console.WriteLine($"El stack tiene {miPila.Count()}");
            miPila.Clear();

            Console.WriteLine($"El stack tiene {miPila.Count()} elementos");


        }
    }
}
