using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_11_Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////matriz para almacenar los nombres de los archivos
            //string[] nombresSubdirectorios;

            ////buscamos archivos en la ruta del proyecto y asignamos la devolución a la matriz del string
            //nombresSubdirectorios = Directory.GetDirectories(@"C:\Users\victor.maureira.g\source\repos\Seccion_11_Archivos\Seccion_11_Archivos\bin\Debug");

            //int indice = 1;

            ////Recorremos la matriz y mostramos sus elementos
            //foreach (string elemento in nombresSubdirectorios)
            //{
            //    Console.WriteLine($"{indice++}: {Path.GetFileName(elemento)}");
            //}


            // variable ruta completa

            //string rutaInicial = @"C:\Users\victor.maureira.g\source\repos\Seccion_11_Archivos\Seccion_11_Archivos\bin\Debug\Seccion_11_Archivos.pdb";

            ////el metodo quita el ultimo elemento de la ruta y lo almacena en la variable string

            //string rutaSinUltimoElemento = Path.GetDirectoryName(rutaInicial);

            //Console.WriteLine(rutaSinUltimoElemento);

            //Cadena con la ruta

            string rutaInicial = @"C:\Users\victor.maureira.g\source\repos";

            //llamamos al metodo

            string[] archivosDirectorios = Directory.GetFileSystemEntries(rutaInicial, "*.txt");

            //recorremos la matriz y mostramos sus elementos
            foreach (string elemenot in archivosDirectorios)
            {
                Console.WriteLine(elemenot);
            }





        }
    }
}
