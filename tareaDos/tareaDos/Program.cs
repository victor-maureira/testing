using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaDos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear un programa que calcule el perimetro de cualquier poligono regular
            int numeroLados;
            double lado, perimetro;

            Console.Write("Ingrese el número de lados del polígono: ");
            numeroLados = Convert.ToInt32(Console.ReadLine()); //convertimos el valor ingresado a tipo int

            Console.Write("Ingrese la medida del lado del polígono: ");
            lado = Convert.ToDouble(Console.ReadLine()); //convertimos el valor ingresado a tipo double

            perimetro = numeroLados * lado; // Cálculo del perímetro

            Console.WriteLine($"El perímetro del polígono de {numeroLados} lados con lado de {lado} es: {perimetro}"); // Mostrar el resultado

            Console.WriteLine(); // Línea en blanco para separar las salidas

            //crear un programa que pase de grados centígrados a grados Fahrenheit

            double gradosCelsius, gradosFahrenheit;

            Console.Write("Ingrese la tempetura en grados Celsius: ");
            gradosCelsius = Convert.ToDouble(Console.ReadLine()); //convertimos el valor ingresado a tipo double

            gradosFahrenheit = (gradosCelsius * 9 / 5) + 32; // Conversión de celsius a Fahrenheit

            Console.WriteLine($"La temperatura de {gradosCelsius}°C corresponde a {gradosFahrenheit}° Fahrenheit"); // Mostrar el resultado

            
        }
    }

}
