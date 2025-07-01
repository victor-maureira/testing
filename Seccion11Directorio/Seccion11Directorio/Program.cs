using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Seccion11Directorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string origenDirectorio = @"C:\Users\victor.maureira.g\source\repos\Seccion11Directorio"; // Ruta de origen del directorio
            string destinoDirectorio = @"C:\Users\victor.maureira.g\Desktop\Seccion11Directorio"; // Ruta de destino del directorio

            // Llamamos al método "CopiarDirectorio" y le enviamos el origen y destino como argumentos
            CopiarDirectorio(origenDirectorio, destinoDirectorio);
        }
        static public void CopiarDirectorio(string origenDirectorioPa, string destinoDirectorioPa)
        {
            // Verificar si el directorio de destino no existe, crearlo si es necesario
            if (!Directory.Exists(destinoDirectorioPa))
            {
                Directory.CreateDirectory(destinoDirectorioPa);
            }

            // Matriz para guardar las rutas completas de los archivos del directorio de origen
            string[] archivos = Directory.GetFiles(origenDirectorioPa);

            // Copiar archivos desde el directorio de origen al directorio de destino
            foreach (string archivoRutaOrigen in archivos)
            {
                // Asignamos el nombre del archivo (matriz) y su extensión a la variable "nombre"
                string nombreArchivo = Path.GetFileName(archivoRutaOrigen);

                // Concatenamos la ruta de destino con el nombre de cada archivo que obtuvimos de la matriz
                string rutaCompletaArchivoDestino = Path.Combine(destinoDirectorioPa, nombreArchivo);

                // Copiamos el archivo de la ruta original en la nueva ruta
                File.Copy(archivoRutaOrigen, rutaCompletaArchivoDestino);
            }

            // Matriz para los nombres de los directorios
            string[] subdirectorios = Directory.GetDirectories(origenDirectorioPa);

            // Recorrer y copiar subdirectorios de manera recursiva
            foreach (string subdirectorioRutaOrigen in subdirectorios)
            {
                // Obtenemos el nombre de cada directorio contenido en la matriz y se lo asignamos a la variable "nombreSubdirectorio"
                string nombreSubdirectorio = Path.GetFileName(subdirectorioRutaOrigen);

                // Concatenamos la ruta de destino con el nombre de cada directorio que obtuvimos de la matriz
                string rutaCompletaSubdirectorioDestino = Path.Combine(destinoDirectorioPa, nombreSubdirectorio);

                // Llamada recursiva para copiar el subdirectorio y sus contenidos.
                // Ahora el nombre completo del subdirectorio será el parámetro "OrigenDirectorioPa"
                // Y "rutaCompletaSubdirectorio" será el parámetro "destinoDirectorioPa"
                CopiarDirectorio(subdirectorioRutaOrigen, rutaCompletaSubdirectorioDestino);
            }
        }
    }
}