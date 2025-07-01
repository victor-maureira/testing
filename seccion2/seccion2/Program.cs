using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que pida al usuario la altura y ancho de un rectángulo y calcule su área y perímetro.

            double altura, ancho, area, perimetro;

            //pedimos la altura

            Console.Write("Ingrese la altura del rectángulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            //pedimos el ancho
            Console.Write("Ingrese el ancho del rectángulo: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            //calculamos el área
            area = altura * ancho;

            //calculamos el perímetro

            perimetro = 2 * (altura + ancho);

            //mostramos los resultados

            Console.WriteLine($"El área del rectángulo es: {area} y el perimetro es: {perimetro}");

           


        }
    }
}
