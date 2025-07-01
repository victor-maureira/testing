using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion10Estructuras
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2;

            //variable que guarda la opcion
            OpcionesMenu opcion;

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");

            Console.Write("Elige una opcion: ");
            opcion = (OpcionesMenu)Enum.Parse(typeof(OpcionesMenu), Console.ReadLine());

            switch (opcion)
            {

                case OpcionesMenu.Suma:
                    Console.WriteLine($"La suma es {a} + {b} = {a+b}");
                    break;


                case OpcionesMenu.Resta:
                    Console.WriteLine($"La resta es: {a - b}");
                    break;

                case OpcionesMenu.Multiplicacion:
                    Console.WriteLine($" {a * b} ");
                    break;

                case OpcionesMenu.Division:
                    Console.WriteLine($" {a / b}");
                        break;


            }

        }



    }

    enum OpcionesMenu { Suma = 1, Resta, Multiplicacion, Division}

  





}

