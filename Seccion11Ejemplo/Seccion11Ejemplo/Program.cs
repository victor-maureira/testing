using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion11Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int opcion;
            bool repetir = true;
            string mensajeParaCifrar, contraseñaMensaje, mensajeCifrado;

            //creamos un flujo/stream  en la memoria RAM
            MemoryStream stream1 = new MemoryStream();

            //Pedimos la cadena que se va a guardar en el flujo
            Console.Write("Ingresa el mensaje que quieres cifrar: ");
            mensajeParaCifrar = Console.ReadLine();

            //Pedimos una contraseña para proteger el mensaje cifrado
            Console.Write("Ingresa una contraseña para proteger el mensaje");
            contraseñaMensaje = Console.ReadLine();

            //Enviamos la cadena dada por el usuario para cifrarla 
            mensajeCifrado = CifrarMensaje(mensajeParaCifrar);

            //declaramos una matriz de bytes y le asignamos la codificacion del mensaje ya cifrado para obtener una secuencia de bytes

            byte[] matrizCadenaByte = Encoding.UTF8.GetBytes(mensajeCifrado);

            //Escribimos el mensaje cifrado en el flujo
            stream1.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);

            Console.WriteLine("El mensaje se encuentra protegido, pulse cualquier tecla para continuar...");
            Console.ReadKey();

            //empezamos a leer el string (cifrado) almacenado en memorystream

            //bufer para almacenar los bytes leidos por Read
            byte[] bufferMatriz = new byte[100];

            //Movemos el puntero al inicio del flujo
            stream1.Seek(0, SeekOrigin.Begin);

            //leemos el contenido de nuestro flujo usando el metodo Read

            stream1.Read(bufferMatriz, 0, (int)bufferMatriz.Length);

            //Descodificamos la matriz de bytes leida para convertirla en un string
            string cadenaDescodificadaCifrada = Encoding.UTF8.GetString(bufferMatriz);

            //Mostramos el Menú

            do
            {
                Console.Clear();

                Console.WriteLine("1. Mostrar Mensaje");

                Console.WriteLine("2. Descifrar Mensaje");

                Console.WriteLine("3. Rendirse");

                Console.Write("Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch(opcion)
                {
                    case 1:
                        Console.WriteLine($"El mensaje es: \"{cadenaDescodificadaCifrada}\"");
                        Console.WriteLine("Pulsa cualquier tecla para continuar.");
                        Console.ReadKey();
                        break;


                    case 2:
                        Console.Write("Ingrese la contraseña para descifrar el mensaje");
                        string posibleContraseña = Console.ReadLine();

                        if (posibleContraseña == contraseñaMensaje)
                        {
                            //mandamos la cadena codificada al metodo descifrar mensaje para ser descifrada, y la devolución la guardamos en una variable local.

                            string mensajeDescifrado = DescifrarMensaje(cadenaDescodificadaCifrada);

                            //mostramos la cadena descifrada

                            Console.WriteLine($"Mensaje: \"{mensajeDescifrado}\"");

                            Console.WriteLine("Pulsa cualquier tecla para continuar.");
                            Console.ReadKey();

                            //cerramos el flujo

                            stream1.Close();

                            //cerramos el programa

                            repetir = false;

                        }
                        else
                        {
                            Console.WriteLine("Contraseña incorrecta. Intenta de nuevo.");

                            Console.WriteLine("Pulsa cualquier tecla para continuar.");
                            Console.ReadKey();
                        }

                            break;

                    case 3:
                        repetir = false;

                        break;


                    default:
                        break;
                }




            } while (repetir);



        }



        static string CifrarMensaje(string mensajeCifrarPa)
        {
            //variable para guardar mensaje cifrado

            string mensajeCifrado;

            //le asignamos el mensaje original a nuestra variable local vacia

            mensajeCifrado = mensajeCifrarPa;

            //reemplazamos vocales por numeros en nuestro mensaje almacenado en la variable local

            mensajeCifrado = mensajeCifrado.Replace('a', '1');
            mensajeCifrado = mensajeCifrado.Replace('e', '2');
            mensajeCifrado = mensajeCifrado.Replace('i', '3');
            mensajeCifrado = mensajeCifrado.Replace('o', '4');
            mensajeCifrado = mensajeCifrado.Replace('u', '5');

            return mensajeCifrado;

        }


        static string DescifrarMensaje(string mensajeCifradoPa)
        {
            //variable que guarda el msj cifrado

            string  mensajeDescifrado;

            //le asignamos el mensaje cifrado   a nuestra variable local vacia 
            mensajeDescifrado = mensajeCifradoPa;

            //reemplazamos los numeros por vocales en nuestro mensaje almacenado de forma local, de esta forma revertimos el cifrado
            mensajeDescifrado = mensajeDescifrado.Replace('1', 'a');
            mensajeDescifrado = mensajeDescifrado.Replace('2', 'e');
            mensajeDescifrado = mensajeDescifrado.Replace('3', 'i');
            mensajeDescifrado = mensajeDescifrado.Replace('4', 'o');
            mensajeDescifrado = mensajeDescifrado.Replace('5', 'u');


            return mensajeDescifrado;

        }
    }
}
