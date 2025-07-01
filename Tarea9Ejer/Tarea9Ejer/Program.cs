using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9Ejer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que pida una fecha y diga que dia nacio

            string cadenaFechaNacimiento;
            DateTime dateTimefechaNacimiento;

            Console.WriteLine("Introduce tu fecha de nacimiento (Dia mes y año) ");
            cadenaFechaNacimiento = Console.ReadLine();

            dateTimefechaNacimiento = DateTime.Parse(cadenaFechaNacimiento);

            Console.WriteLine($"Naciste un {dateTimefechaNacimiento.ToString("dddd")}");



        }
    }
}
