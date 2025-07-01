using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Tarea Cinco.
 * parte 1: Crear un método para transformar de grados a radianes
 * parte 2:Crear una aplicación que calcule el área de un círculo, cuadrado o triangulo. Le preguntaremos al usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de los 3 métodos (recordar tuplas)*/

namespace TareaCinco
{
    

    internal class Program
    {

        //declaracion de la tupla para el area del triangulo
        public const decimal PI = 3.141592653589793M;


        //metodo para convertir grados a radianes

        static decimal conversorGradosRadianes(decimal grados)
        {
            decimal radianes = (decimal)(grados * PI / 180);
            return radianes;
        }

        //metodo para calcular el area de un circulo
        static float AreaCirculo(float radio)
        {
            float area = (float)(Math.PI * Math.Pow((float)radio, 2));
            return area;
        }

        //metodo para calcular el area de un cuadrado
        static decimal AreaCuadrado(decimal lado)
        {
            decimal area = lado * lado;
            return area;
        }

        //metodo para calcular el area de un triangulo
        static decimal AreaTriangulo(decimal baseTriangulo, decimal altura)
        {
            decimal area = (baseTriangulo * altura) / 2;
            return area;
        }

        //metodo para solicitar valores al usuario y calcular el area de la figura seleccionada
        static void CalcularAreaFigura()
        {
            int opcion;
            do
            {
                Console.WriteLine("Seleccione la figura para calcular el área: \n1. Círculo\n2. Cuadrado\n3. Triángulo");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion < 1 || opcion > 3);

            // Solicitar los valores necesarios según la figura seleccionada
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el radio del círculo: ");
                    float radio = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine($"El área del círculo es: {AreaCirculo(radio)}");
                    break;
                case 2:
                    Console.Write("Ingrese el lado del cuadrado: ");
                    decimal lado = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"El área del cuadrado es: {AreaCuadrado(lado)}");
                    break;
                case 3:
                    Console.Write("Ingrese la base del triángulo: ");
                    decimal baseTriangulo = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    decimal altura = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"El área del triángulo es: {AreaTriangulo(baseTriangulo, altura)}");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }



        static void Main(string[] args)
        {
            // Parte 1: Conversión de grados a radianes
            Console.Write("Ingrese los grados a convertir a radianes: ");
            decimal grados = Convert.ToDecimal(Console.ReadLine());
            decimal radianes = conversorGradosRadianes(grados);
            Console.WriteLine($"{grados} grados son {radianes} radianes.");
            // Parte 2: Calcular el área de una figura
            CalcularAreaFigura();


        }
    }
}
