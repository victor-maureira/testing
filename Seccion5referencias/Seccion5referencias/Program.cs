using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion5referencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Luis";
            byte edad = 30;
            long telefono = 1234567890;
            int dirPostal = 12345;

            var personaUno = (nombre :"Luis", edad: 30, telefono: 1234567890, dirPostal: 12345);

            Console.WriteLine(personaUno.nombre,edad);
            Console.WriteLine($"{nombre} tiene {edad} años, su teléfono es {telefono} y su código postal es {dirPostal}.");
        }



    }
}
