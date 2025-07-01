using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Seccion9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 

            string cadenaFechaHora;
            DateTime dateTimeFechaHora;

            Console.Write("Ingrese una fecha y hora: ");
            cadenaFechaHora = Console.ReadLine();

            // Intentar convertir la cadena a DateTime usando el formato especificado

            dateTimeFechaHora = DateTime.Parse(cadenaFechaHora);

            Console.Write(dateTimeFechaHora);

        }
    }
}