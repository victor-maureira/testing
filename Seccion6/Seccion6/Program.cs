using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seccion6Tarea
{

    internal class Program
    {
        /* TAREA 6:
         * 1. Agregar el cálculo del promedio de calificaciones para cada salón en el ejercicio de matrices escalonadas.
         * 2. Agregar el cálculo de la menor calificación para cada salón en el ejercicio de matrices escalonadas.
         * 3. Agregar el cálculo de la mayor calificación para cada salón en el ejercicio de matrices escalonadas.
         * 4. Agregar cambios estéticos al programa para que no se vea amontonado, algunos espacios y títulos vendrían bien.
         */








        static void Main(string[] args)
        {
            //Variables
            byte i, j, numAlumnos, salones;
            double sumaCalif = 0, sumaCalifSalon, totalAlumnos = 0, promedio, califMin = 10, califMax = 0;

            //Pedimos el número de salones
            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            //Creación de la matriz
            double[][] calificaciones = new double[salones][];

            //Espacio en blanco
            Console.WriteLine();

            // Pedimos el número de alumnos por salón
            for (i = 0; i < salones; i++)
            {
                Console.Write("Ingrese el número de alumnos para el salón {0}: ", i);
                numAlumnos = Convert.ToByte(Console.ReadLine());

                //Acumulamos el número de alumnos totales, para el promedio de toda la escuela
                totalAlumnos += numAlumnos;

                //Instanciamos las matrices internas (alumnos en cada salón)
                calificaciones[i] = new double[numAlumnos];
            }

            //Espacio en blanco
            Console.WriteLine();

            //Declaramos matrices unidimensionales para almacenar datos por salón
            double[] califMinSalon = new double[salones];
            double[] califMaxSalon = new double[salones];
            double[] promedioSalon = new double[salones];

            //Pedimos las calificaciones de los alumnos de cada salón
            for (i = 0; i < salones; i++)
            {
                /*Los valores de calMax, calMin y sumaCalifSalon se tienen que reiniciar a un valor de cero en cada vuelta del ciclo, para que puedan ser comparados nuevamente en cada salón, o de lo contrario se quedaran con los últimos valores que acumularon o encontaron */
                sumaCalifSalon = 0;
                califMax = 0;
                califMin = 10;

                //Mostramos el salón en el que estamos
                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    //Pedimos la calificación
                    Console.Write("Ingresa la calificación del alumno {0}: ", j);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    //Acumulamos las calificaciones de toda la escuela
                    sumaCalif += calificaciones[i][j];

                    //Acumulamos las calificaciones por salón
                    sumaCalifSalon += calificaciones[i][j];

                    //Encontramos la calificación mínima en cada salón
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                    //Asignamos la calificación más baja encontrada, en la casilla correspondiente al salón
                    califMinSalon[i] = califMin;

                    //Encontramos la calificación máxima en cada salón
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                    //Asignamos la calificación más alta encontrada, en la casilla correspondiente al salón
                    califMaxSalon[i] = califMax;
                }
                //Calculamos el promedio de cada salón
                promedioSalon[i] = sumaCalifSalon / calificaciones[i].Length;
            }

            //Calculamos el promedio de toda la escuela
            promedio = sumaCalif / totalAlumnos;

            /*El cálculo de las calificaciones mínima y máxima para toda la escuela se tiene que volver a hacer, usando otras instrucciones de iteración, porque el reinicio de los valores en las variables causaria conflicto*/

            //Calculamos la calificación mínima y máxima para toda la escuela en un mismo "for"
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    // Calificación mínima
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                    // Calificación máxima
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }
            //Espacio en blanco
            Console.WriteLine();
            Console.WriteLine();

            //Titulo para indicar que estamos mostrando información
            Console.WriteLine("¡DATOS DE LA ESCUELA!");

            //Espacio en blanco
            Console.WriteLine();


            //Mostramos las calificaciones de todos los alumnos de la escuela
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("El alumno {0}, tiene {1} de calificación", j, calificaciones[i][j]);
                }
            }

            //Espacio en blanco
            Console.WriteLine();

            //Mostramos los resultados de cada salón
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("INFORMACIÓN DEL SALÓN {0}: ", i);
                Console.WriteLine("Calificación máxima: {0}, calificación mínima: {1}", califMaxSalon[i], califMinSalon[i]);
                Console.WriteLine("Promedio: {0}", promedioSalon[i]);
            }

            //Espacio en blanco
            Console.WriteLine();

            //Mostramos los resultados para toda la escuela
            Console.WriteLine("El promedio de toda la escuela es: {0}", promedio);
            Console.WriteLine("La calificación más baja de la escuela es: {0}", califMin);
            Console.WriteLine("La calificación más alta de la escuela es: {0}", califMax);
        }






    }











    }








































//namespace Seccion6
//{
//    //internal class Program
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        string[] nombres = new string[3];



//    //        byte i; //variable de control del ciclo

//    //        for (i = 0; i <= 2; i++)
//    //        {
//    //           Console.WriteLine($"Ingresa el valor para el indice {i}");
//    //            nombres[i] = Console.ReadLine();
//    //        }

//    //        // mostramos los valores ingresados
//    //        Console.WriteLine("Los valores ingresados son: ");
//    //        for (i = 0; i <= 2; i++)
//    //        {
//    //            Console.WriteLine($"Indice {i} : {nombres[i]}");
//    //        }


//    //    }
//    //}

//    //internal class Program
//    //{

//    //    static void Main(string[] args)

//    //{
//    //        byte i, j, numAlumnos, salones;
//    //    double sumCalif = 0, promedio, califMin = 10, califMax = 0;


//    //        //pedimos el numero de salones

//    //    Console.WriteLine("Ingrese el numero de salones: ");
//    //    salones = Convert.ToByte(Console.ReadLine());

//    //        //pedimos el numero de alumnos

//    //    Console.WriteLine("Ingrese el numero de alumnos por salón: ");
//    //    numAlumnos = Convert.ToByte(Console.ReadLine());

//    //    //creacion matriz, el tamaño depende del numero de alumnos leido

//    //    double[,] calificaciones = new double[salones, numAlumnos];

//    //    //for para pedir calificaciones 

//    //    for (i = 0; i < salones; i++)
//    //    {
//    //            Console.WriteLine($"Salon {i + 1}");

//    //            for (j = 0; j < numAlumnos; j++)
//    //            {
//    //                Console.WriteLine($"Ingrese la calificacion del alumno:");
//    //                calificaciones[i,j] = Convert.ToDouble(Console.ReadLine());
//    //                //acumulamos las calificaciones
//    //                sumCalif += calificaciones[i, j];
//    //            }


//    //    }

//    //    //calculamos el promedio

//    //    promedio = sumCalif / ( salones * numAlumnos ) ;


//    //    // calculamos calificacion minima 

//    //    for (i = 0; i < numAlumnos; i++)
//    //    {
//    //        for (j = 0; j < salones; j++)
//    //        {
//    //            if (calificaciones[j, i] < califMin)
//    //            {
//    //                califMin = calificaciones[j, i];
//    //            }
//    //            }
//    //        }

//    //    //calculamos calificacion maxima

//    //    for (i = 0; i < numAlumnos; i++)
//    //    {
//    //       for (j = 0; j < salones; j++)
//    //        {
//    //            if (calificaciones[j, i] > califMax)
//    //            {
//    //                califMax = calificaciones[j, i];
//    //            }
//    //            }
//    //        }


//    //    //mostramos resultados
//    //    Console.WriteLine($"El promedio es: {promedio}");
//    //    Console.WriteLine($"La calificacion minima es: {califMin}");
//    //    Console.WriteLine($"La calificacion maxima es: {califMax}");

//    //}

//    //class Program
//    //{

//    //    // matriz multidimensional
//    //    static void Main(string[] args)
//    //    {
//    //        //variables control ciclo
//    //        int fila; //variable de control del ciclo interior
//    //        int columna; //variable de control del ciclo exterior


//    //        //tipo [,] nombre = new tipo[filas, columnas];
//    //        double[,] ventas = new double[4, 3]
//    //        { { 100, 120, 205 },
//    //          { 115, 196, 300 },
//    //          { 157, 172, 245 },
//    //         { 130, 180, 281 } };


//    //        for (fila = 0; fila < 4; fila++) //ciclo exterior para filas
//    //        {
//    //            Console.WriteLine($"Fila {fila}");
//    //            for (columna = 0; columna < 3; columna++)  //ciclo interior para columnas
//    //            {
//    //                Console.WriteLine(ventas[fila, columna]); //imprimir el valor de la matriz en una posicion especifica
//    //            }
//    //        }











//    //    }

//    //}
//    //internal class Program
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        ////matriz escalonada (jagged)
//    //        ////tipo[][] nombre = new tipo[filas][];

//    //        //int i, j; //variables de control del ciclo

//    //        //double[][] ventas = new double[4][];

//    //        ////declaracion de las matrices internas e inicializacion
//    //        //ventas[0] = new double[3] { 155, 100, 170 };
//    //        //ventas[1] = new double[2] { 205, 220 };
//    //        //ventas[2] = new double[4] { 115, 190, 104, 130 };
//    //        //ventas[3] = new double[3] { 163, 218, 125 };

//    //        //for ( i = 0; i < ventas.Length; i++) // de 0 a 3 recorriendo todas las matrices internas
//    //        //{
//    //        //    Console.WriteLine($"Elemento: {i}");

//    //        //    for (j =0; j < ventas[i].Length; j++)
//    //        //    {
//    //        //        Console.WriteLine($"Valor: {ventas[i][j]}"); //imprimir el valor de la matriz en una posicion especifica
//    //        //    }

//    //        //}

//    //    }
//    //}





//    //internal class Program
//    //{

//    //    static void Main(string[] args)
//    //    {
//    //        //ejercicio con matrices escalonadas (jagged)

//    //        byte i, j, numAlumnos, salones;
//    //        double sumCalif = 0, sumAlumnos = 0, promedio, califMin = 10, califMax = 0;


//    //        //pedimos el numero de salones

//    //        Console.WriteLine("Ingrese el numero de salones: ");
//    //        salones = Convert.ToByte(Console.ReadLine());

//    //        double[][] calificaciones = new double[salones][];

//    //        //pedimos numero de alumnos por salon

//    //        for (i = 0; i < salones; i++)
//    //        {
//    //            Console.WriteLine($"Ingrese el numero de alumnos para el salon {i + 1}: ");
//    //            numAlumnos = Convert.ToByte(Console.ReadLine());
//    //            sumAlumnos += numAlumnos; //acumulamos el numero de alumnos
//    //            calificaciones[i] = new double[numAlumnos]; //instanciamos la matriz interna para cada salon
//    //        }







//    //        //for para pedir calificaciones de los alumnos de cada salon

//    //        for (i = 0; i < salones; i++)
//    //        {
//    //            Console.WriteLine($"Salon {i + 1}");

//    //            for (j = 0; j < calificaciones[i].Length; j++)
//    //            {
//    //                Console.WriteLine($"Ingrese la calificacion del alumno {j+1}: ");
//    //                calificaciones[i] [j] = Convert.ToDouble(Console.ReadLine());
//    //                //acumulamos las calificaciones
//    //                sumCalif += calificaciones[i] [j];
//    //            }


//    //        }

//    //        //calculamos el promedio

//    //        promedio = sumCalif / sumAlumnos;


//    //        // calculamos calificacion minima 

//    //        for (i = 0; i < salones; i++)
//    //        {
//    //            for (j = 0; j < calificaciones[i].Length; j++)
//    //            {
//    //                if (calificaciones[i][j] < califMin)
//    //                {
//    //                    califMin = calificaciones[i][j];
//    //                }
//    //            }
//    //        }

//    //        //calculamos calificacion maxima

//    //        for (i = 0; i < salones; i++)
//    //        {
//    //            for (j = 0; j < calificaciones [i].Length; j++)
//    //            {
//    //                if (calificaciones[i] [j] > califMax)
//    //                {
//    //                    califMax = calificaciones[i][j];
//    //                }
//    //            }
//    //        }

//    //        //mostramos calificaciones de todos los alumnos
//    //        for (i = 0; i < salones; i++)
//    //        {
//    //            Console.WriteLine($"Salon {i + 1}");

//    //            for (j = 0; j < calificaciones[i].Length; j++)
//    //            {
//    //                Console.WriteLine($"el alumno {j + 1} tiene una calificacion de: {calificaciones[i][j]}");
//    //            }


//    //        }



//    //        //mostramos resultados
//    //        Console.WriteLine($"El promedio es: {promedio}");
//    //        Console.WriteLine($"La calificacion minima es: {califMin}");
//    //        Console.WriteLine($"La calificacion maxima es: {califMax}");




//    //    }




//    //}




//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            //matriz escalonada con asignacion implicita de tipo
//            var matrizJagged = new[]
//            {
//                new[] {12, 23},
//                new[] {15, 30}
//            };









//            //    int[] matriz = { 1, 2, 3, 4 ,5 , 6, 7, 8, 9, 10 };
//            //    //llamamos al metodo para imprimir la matriz

//            //    ImprimirMatriz(matriz);

//            //    //matriz multidimensional
//            //    double[,] matriz2D = { { 1, 2 }, 
//            //                           { 3, 4 } };

//            //    ImprimirMatriz2D(matriz2D);
//            //}

//            ////metodo que imprime los valores de una matriz

//            //static void ImprimirMatriz(int[] matrizPa)
//            //{
//            //    int i;

//            //    for (i = 0; i < matrizPa.Length; i++)
//            //    {
//            //        Console.WriteLine($"Indice {i} : {matrizPa[i]}");
//            //    }
//            //}



//            ////metodo que imprime los valores de una matriz 2D
//            //static void ImprimirMatriz2D(double[,] matriz2DPa)
//            //{
//            //               int i, j;
//            //    for (i = 0; i < matriz2DPa.GetLength(0); i++) // GetLength(0) devuelve el numero de filas
//            //    {
//            //        for (j = 0; j < matriz2DPa.GetLength(1); j++) // GetLength(1) devuelve el numero de columnas
//            //        {
//            //            Console.WriteLine($"Fila {i}, Columna {j} : {matriz2DPa[i, j]}");
//            //        }
//            //    }
//            //}

//        }



//    }

//    }







//////declaracion e instancia de matriz de 3 dimensiones

////int[,,] matriz3D = new int[2, 2, 3] 
////{ { {1,2,3}, {4,5,6} },
////{ {7,8,9 }, {10,11,12} }   };


////Console.WriteLine(matriz3D[0, 0, 1]); //imprimir un valor de la matriz en una posicion especifica