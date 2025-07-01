using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Seccion8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables

            int opcion, indice;
            string alumno;

            //Instancia coleccion list

            List<string> Alumnos = new List<string>();

            do
            {
                Console.Clear();

                //pequeño menu
                Console.WriteLine("1. Agregar Estudiante");
                Console.WriteLine("2. Eliminar Estudiante");
                Console.WriteLine("3. Mostrar Estudiante");
                Console.WriteLine("4. Buscar por Nombre");

                Console.Write("Escoge una opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write(" Ingrese el nombre del alumno:");
                        alumno = Console.ReadLine();

                        Alumnos.Add(alumno);
                        break;

                    case 2:
                        Console.Write(" Ingrese el numero del estudiante a eliminar:");
                        indice = Convert.ToInt32(Console.ReadLine());

                        indice--; //reduce en 1 el indice para evitar confusion con el usuario, ya que no sabe que comienza en 0

                        if (indice >= Alumnos.Count() || indice < 0)
                        {
                            Console.WriteLine("El alumno no existe.");
                        }
                        else
                        {
                            string alumnoElim = Alumnos[indice];
                            Alumnos.RemoveAt(indice); //quitamos al alumno en la lista
                            Console.WriteLine($"{alumnoElim} ha sido eliminado de la lista.");
                        }

                        Console.Write("Pulse cualquier tecla para regresar al menu.");
                        Console.ReadKey();
                        break;

                    case 3:
                        int i = 1; //sirve para mostrar el indice de los alumnos

                        foreach (string estudiante in Alumnos)
                        {
                            Console.WriteLine($"{i++}. {estudiante}");
                        }

                        Console.Write("Pulse cualquier tecla para regresar al menu.");
                        Console.ReadKey();
                        break;

                    case 4:
                        string encontrarAlumn;
                        int j; //numero de lista 

                        Console.WriteLine("ingrese el nombre del estudiante a buscar:");
                        alumno = Console.ReadLine();

                        //verificar si el alumno está o no en la lista
                        if (Alumnos.IndexOf(alumno) >= 0)
                        {
                            encontrarAlumn = Alumnos[Alumnos.IndexOf(alumno)];//alumnos[3]
                            j = Alumnos.IndexOf(alumno) + 1;

                            Console.WriteLine($"El estudiante {encontrarAlumn} se encuentra en el numero {j} de la lista.");
                        }
                        else
                        {
                            Console.WriteLine($"El estudiante {alumno} no se encuentra en el sistema.");
                        }

                        Console.Write("\nPulse cualquier tecla para regresar al menu.");
                        Console.ReadKey();

                        break;
                }
            } while (opcion >= 1 && opcion <= 4); // Corrección: Se agregó el 'while' al final del bloque 'do-while'
        }
    }

}
