using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PARTE 1: AGREGAR OPCION 5, (5. Actualizar contacto) al ejercicio con "Dictionary" de la agenda telefónica haciendo uso de la propiedad "Item[ ]".


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
                Console.WriteLine("5. Actualizar Contacto");

                Console.Write("\n Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
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

                        if (contactos.ContainsKey(nombre))
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

                        foreach (KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine($"{elemento.Key}, {elemento.Value}");
                        }
                        Console.WriteLine($"\n Pulse cualquier tecla para regresar al menú.");
                        Console.ReadKey();
                        break;


                    case 5:
                        Console.WriteLine("\n Ingrese el nombre del contacto a actualizar:");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine($"El contacto {nombre} se encuentra. Ingrese los nuevos datos para actualizar:");
                            Console.Write("Nuevo nombre: ");
                            string nuevoNombre = Console.ReadLine();
                            Console.Write("Nuevo Telefono:");
                            long nuevoTelefono = Convert.ToInt64(Console.ReadLine());

                            // Si el nombre no cambia, solo actualiza el teléfono
                            if (nuevoNombre == nombre)
                            {
                                contactos[nombre] = nuevoTelefono;
                            }
                            else
                            {
                                // Elimina el contacto anterior y agrega el nuevo
                                contactos.Remove(nombre);
                                contactos[nuevoNombre] = nuevoTelefono;
                            }

                            Console.WriteLine("Se ha actualizado el contacto.");

                            Console.WriteLine($"\n Pulse cualquier tecla para regresar al menú.");
                            Console.ReadKey();

                        }
                        else
                        {

                            Console.WriteLine($"\n ese weon/a no existe papito.");

                            Console.WriteLine($"\n Pulse cualquier tecla para regresar al menú.");
                            Console.ReadKey();

                        }

                            break;
                }


            } while (opcion >= 1 && opcion <= 5);
        }
    }
}
