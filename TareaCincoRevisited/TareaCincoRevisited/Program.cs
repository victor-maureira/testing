using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCincoRevisited
{
    //    internal class Program
    //    {

    //        static double gradosRadianes(double gradosPa)
    //        {
    //            double radianes;

    //            radianes = (gradosPa * Math.PI) / 180;
    //            return radianes;
    //        }





    //        static void Main(string[] args)
    //        {
    //            double gradosAr, radianes;

    //            Console.WriteLine("Ingrese el valor en grados: ");
    //            gradosAr = Convert.ToDouble(Console.ReadLine());

    //            radianes = gradosRadianes(gradosAr);

    //            Console.WriteLine($"el resultado de {gradosAr} grados a radianes es: {radianes}");

    //        }
    //    }
    //}


    internal class Program
    {



        static double areaCirculo(double radioPa)
        {
            double area;
            area = Math.PI * Math.Pow(radioPa, 2);
            return area;
        }

        static double areaTriangulo(double basePa, double alturaPa)
        {
            double area;
            area = (basePa * alturaPa) / 2;
            return area;
        }

        static double areaCuadrado(double ladoPa)
        {
            double area;
            area = ladoPa * ladoPa;
            return area;
        }



        static void Main(string[] args)
        {
            double radioAr, baseAr, alturaAr, ladoAr, area;
            byte opcion;


            Console.WriteLine("Ingresa una opcion y calcularé su area. \n1. Circulo \n2. Triangulo \n3. Cuadrado");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el radio del circulo: ");
                    radioAr = Convert.ToDouble(Console.ReadLine());
                    radioAr = areaCirculo(radioAr);
                    Console.WriteLine($"El area del circulo es: {radioAr}");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la base del triangulo: ");
                    baseAr = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo: ");
                    alturaAr = Convert.ToDouble(Console.ReadLine());
                    area = areaTriangulo(baseAr, alturaAr);
                    Console.WriteLine($"El area del triangulo es: {area}");
                    break;
                case 3:
                    Console.WriteLine("Ingresa el lado del cuadrado: ");
                    ladoAr = Convert.ToDouble(Console.ReadLine());
                    area = areaCuadrado(ladoAr);
                    Console.WriteLine($"El area del cuadrado es: {area}");
                    break;



            }


        }


    }











}