using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Seccion11Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //flujos o streams

            MemoryStream stream1 = new MemoryStream();
         
            InformacionStream(stream1);
            //Matriz de bytes para guardar la cadena compartida

            byte[] matrizcadenaByte;

            //solicitamos ingresar una cadena
            Console.Write("Ingrese una cadena: ");
            string cadenaUsuario = Console.ReadLine();

            //codificamos a cadena 1 para obtener una secuencia de bytes
            matrizcadenaByte = Encoding.UTF8.GetBytes(cadenaUsuario);

            //escribiendo datos en el flujo
            stream1.Write(matrizcadenaByte, 0 , matrizcadenaByte.Length);

            Console.WriteLine("Despues de escribir en el stream...");
            //Mostramos capacidad, longitud y posicion del puntero del stream
            InformacionStream(stream1);

            //declaramos bufer para almacenar los bytes leidos por Read

            byte[] bufferBytesLeidos = new byte[100];

            stream1.Seek(0, SeekOrigin.Begin ); //mover el puntero al inicio del flujo

            //leemos el contenido del flujo

            int bytesLeidos = stream1.Read(bufferBytesLeidos, 0, (int)stream1.Length);

            Console.WriteLine($"Bytes leidos del stream: {bytesLeidos}");

            //Descodificamos la matriz de bytes leida para convertirla en un string

           string cadenaDescodificada = Encoding.UTF8.GetString(bufferBytesLeidos);

            Console.WriteLine($"La cadena descodificada es: {cadenaDescodificada}");

            //cerramos flujo

            stream1.Close();

            InformacionStream(stream1);


        }

        static void InformacionStream(MemoryStream ms1Pa)
        {
            Console.WriteLine($"Capacidad: {ms1Pa.Capacity}");
            Console.WriteLine($"Longitud: {ms1Pa.Length}");
            Console.WriteLine($"Posicion: {ms1Pa.Position}");
        }
    }
}
