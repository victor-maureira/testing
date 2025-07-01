using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables

            int i; //variable que se encarga del bucle exterior
            int j; //variable que se encarga del bucle interior
            int resultado; //variable que almacena el resultado de la multiplicación

            for (i = 1; i <= 10; i++) //bucle exterior
            {
                Console.WriteLine("Tabla del " + i); //imprime el número de la tabla

                for (j = 1; j<=10; j++)
                {
                    resultado = i * j; //realiza la multiplicación}

                    Console.WriteLine($"{i} x {j} = {resultado}"); //imprime el resultado de la multiplicación
                }
            }

            Console.ReadKey(); //espera a que el usuario presione una tecla antes de cerrar la consola
        }
    }
}
