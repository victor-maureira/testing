using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            decimal valorResta; //almacena el valor devuelto de restar
            decimal num1Ar, num2Ar; //argumentos para enviar una copia de su valor hacia los metodos
            //declaramos una tupla
            (decimal num1, decimal num2, decimal resultado) numeros; //declaramos una tupla para almacenar los numeros y el resultado de la operacion

            do
            {

                Console.WriteLine("Ingrese una opcion: \n1.Sumar \n2.Restar \n3.Multiplicar \n4.Dividir: ");
                opcion = Convert.ToInt32(Console.ReadLine());

            }
            while (opcion < 1 || opcion > 4);

            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    // asignar a la tupla numeros el resultado de la resta
                    numeros = Restar();

                    Console.WriteLine($"el resultado de la resta es: {numeros.resultado}");
                    break;

                case 3:

                    // Llamar al método Multiplicar
                   num1Ar = SolicitarNumero("Ingrese el primer numero: ");
                   num2Ar = SolicitarNumero("Ingrese el segundo numero: ");


                    Multiplicar(num1Ar, num2Ar);
                    break;

                case 4:

                    // Llamar al método Dividir
                   num1Ar = SolicitarNumero("Ingrese el primer numero: ");
                   num2Ar = SolicitarNumero("Ingrese el segundo numero: ");
                    decimal valorDivision = Division(num1Ar, num2Ar);


                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        }

        //declaracion de un metodo, suma.

        static void Sumar()
        {
            int numero1, numero2, resultado;
            Console.Write("Ingrese el primer numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero1 + numero2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");

        }


        static (decimal, decimal, decimal) Restar()
        {
            int numero1, numero2, resultado;
            Console.Write("Ingrese el primer numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());


            resultado = numero1 - numero2;


            //devolvemos multiples tipos al autor del llamado
            return (numero1, numero2, resultado); //retornamos una tupla con los numeros y el resultado de la resta
        }

        static void Multiplicar(decimal num1Pa, decimal num2Pa)
        {
            decimal resultado;
            resultado = num1Pa * num2Pa;
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        }

        static decimal Division(decimal num1Pa, decimal num2Pa)
        {
            decimal resultadoDivision;

            if (num2Pa == 0)
            {
                Console.WriteLine("Error: División por cero no permitida.");
                return 0; // o lanzar una excepción
            }
            else
            {
                resultadoDivision = num1Pa / num2Pa;
                Console.WriteLine($"El resultado de la división es: {resultadoDivision}");
                return resultadoDivision;
            }
        }

        // Mover el método solicitarNumero fuera del método Division para evitar el error CS8370
        static decimal SolicitarNumero(string peticion)
        {
            decimal numero;

            Console.Write(peticion);

            numero = Convert.ToDecimal(Console.ReadLine());

            return numero;
        }
    }

}


///*
//namespace Seccion5Ejemplo
//{
//    internal class Program
//    {

//        static void saludoInicial()
//        {
//            Console.WriteLine("¡Bienvenido al programa de ejemplo!");
//        }

//        static void solicitarNombre(string nombre)
//        {
//           /* Console.Write("¿Cual es tú nombre?");
//                nombre = Console.ReadLine(); */
//            Console.WriteLine($"Hola, {nombre}! Es un placer conocerte.");
//        }

//        static int pedirNumero()
//        {
//            Console.Write("Por favor, ingresa un número: ");
//            int numero = Convert.ToInt32(Console.ReadLine());
//            return numero;
//        }


//        static int sumarNumeros(int num1, int num2)
//        {
//            return num1 + num2;
//        }


//        static void Main(string[] args)
//        {
//            saludoInicial();

//            Console.Write("Cúal es tu nombre? :");
//            string nombre = Console.ReadLine();
//            solicitarNombre(nombre);

//            int numero1 = pedirNumero();
//            int numero2 = pedirNumero();

//            int resultado = sumarNumeros(numero1, numero2);

//            Console.WriteLine($"La suma de {numero1} y {numero2} es: {resultado}");

//        }
//    }
//}

