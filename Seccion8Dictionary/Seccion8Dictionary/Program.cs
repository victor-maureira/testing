using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion8Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio con dictionary. Agenda con nombre y telefono

            //variables
            int opcion;
            string nombre;
            long numero;

            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();

                //Menu
                Console.WriteLine("1. Agregar Contacto");
                Console.WriteLine("2. Buscar Contacto");
                Console.WriteLine("3. Eliminar Contacto");
                Console.WriteLine("4. Mostrar Contacto");

                Console.Write("\n Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre:");
                        nombre = Console.ReadLine();

                        Console.Write("Ingrese el numero:");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);

                        Console.WriteLine($"\n El contacto {nombre} ha sido agregado.");

                        Console.WriteLine($"\n Pulse cualquier tecla para regresar al menú.");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.Write("Ingrese el nombre del contacto a buscar:");
                        nombre = Console.ReadLine();

                        if(contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine($"El contacto {nombre}, {contactos[nombre]} se ha encontrado.");

                            Console.WriteLine($"\n Pulse cualquier tecla para regresar al menú.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("EL contacto no existe.");

                            Console.WriteLine($"\n Pulse cualquier tecla para regresar al menú.");
                            Console.ReadKey();
                        }
                            break;

                    case 3:
                        Console.Write("Ingrese el nombre del contacto a eliminar:");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);
                            Console.WriteLine($"El contacto {nombre} se ha eliminado.");

                            Console.WriteLine($"\n Pulse cualquier tecla para regresar al menú.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("EL contacto no existe.");

                            Console.WriteLine($"\n Pulse cualquier tecla para regresar al menú.");
                            Console.ReadKey();
                        }

                        break;

                    case 4:
                        Console.WriteLine("\n Contactos en tu agenda:");

                        foreach(KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine($"{elemento.Key}, {elemento.Value}");
                        }
                        Console.WriteLine($"\n Pulse cualquier tecla para regresar al menú.");
                        Console.ReadKey();
                        break;
                }


            } while (opcion >= 1 && opcion <= 4);

        }
    }
}
