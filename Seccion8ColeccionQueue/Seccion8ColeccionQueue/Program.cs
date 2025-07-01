using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion8ColeccionQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //queue

            Queue<char> mifila = new Queue<char>();

            //agregando objetos

            mifila.Enqueue('A');

            mifila.Enqueue('B');

            mifila.Enqueue('C');

            mifila.Enqueue('D');

            int i = 0; //recorriendo queue

            foreach (char elemento in mifila)
            {
                Console.WriteLine($"{i++}.  {elemento}");
            }

            //agregando otro elemento

            Console.WriteLine("\nDespues de agregar a: (e)");
            mifila.Enqueue('e');

            i = 0; //recorriendo queue

            foreach (char elemento in mifila)
            {
                Console.WriteLine($"{i++}.  {elemento}");
            }

            //despues de quitar un elemento

            Console.WriteLine("Despues de quitar el elemento:");
           var objEliminado = mifila.Dequeue();

            i = 0;


            foreach (char elemento in mifila)
            {
                Console.WriteLine($"{i++}.  {elemento}");
            }

            Console.WriteLine($"El elemento {objEliminado} fue eliminad correctamenet.e.");

        }
    }
}
