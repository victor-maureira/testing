using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_11_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable que va a guarda la ruta a explorar
            string directorio;

            do
            {
                Console.Write("Por favor, ingrese la ruta del directorio: ");
                directorio = Console.ReadLine();

                //verifica si el directorio existe
                if (!Directory.Exists(directorio))
                {
                    Console.WriteLine("La ruta ingresada no existe.");
                }



            } while (!Directory.Exists(directorio)); //mientras el directorio ingresado no exista, seguiremos pidiendo uno valido


            //Si el directorio ingresado existe, salimos del ciclo y ejecutamos el método con ese directorio como argumento

            ExplorarDirectorio(directorio);
        }

        static void ExplorarDirectorio(string directorioPa)
        {
            //variable que controla el ciclo
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                //Mostramos un mensaje con el nombre del directorio que estamos explorando
                Console.WriteLine($"Contenido de {directorioPa}\n");

                //obtenemos una lista de todos los archivos y subdirectorios

                string[] archivosSubdirectorios = Directory.GetFileSystemEntries(directorioPa);

                //mostramos el contenido del directorio en una tabla
                MostrarTabla(archivosSubdirectorios);


                //le pedimos al usuario que ingrese una opcion de las mostradas en la tabla, según su indice. O le damos la opción de salir (s) del programa, o de navegar hacia atras en la ruta (a)
                Console.Write("Ingresa el numero de la opcion que deseas explorar (o 'a' para ir hacia atrás en la ruta, 'n' para ingresar una nueva ruta o 's' para salir.");
                string opcion = Console.ReadLine();
            }
        }


        //metodo usado para mostrar a los archivos y subdirectorios en una tabla ordenada

        static void MostrarTabla(string[] archivosSubdirectoriosPa)
        {
            //Imprimimos los titulos de la tabla, dejando espacios y colocandolos a la izquierda
            Console.WriteLine($"{"Indice",-8}{"Nombre",-50}{"Tipo",-13}");

            //instanciamos a la clase String en la cual creamos una cadena con guiones que separen a los titulos del contenido de la tabla y lo hacemos del total del espacio de la suma de los titulos (8 + 50 + 13)   
            String guiones = new string('-', 71);

            Console.WriteLine(guiones);

            //variables para guardar el nombre del archivo/subdirectorio y su tipo  
            string nombre, tipo;

            //recorremos la matriz que contiene a los archivos y subdirectorios

            for (int i = 0; i < archivosSubdirectoriosPa.Length; i++)
            {
                // extraemos solo el nombre del archivo o subdirectorio de la posicion en la que nos encontremos y se lo asignamos a una variable "nombre"
                nombre = Path.GetFileName(archivosSubdirectoriosPa[i]);

                if (Directory.Exists(archivosSubdirectoriosPa[i]))
                {
                    //Entonces el tipo sera subdirectorio
                    tipo = "subdirectorio";
                }
                else
                {
                    //si no, entonces extraemos la extension del archivo en el que estemos y se la asignamos a "tipo"
                    tipo = Path.GetExtension(archivosSubdirectoriosPa[i]);
                }

                //mostramos un indice para el elemento en el que estemos, su nombre y su tipo
                Console.WriteLine($"{i,-8}{nombre,-50}{tipo,-13}");
            }

            Console.WriteLine();
        }
    }
}
