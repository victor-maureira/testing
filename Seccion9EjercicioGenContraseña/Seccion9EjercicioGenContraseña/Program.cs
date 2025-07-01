using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Seccion9EjercicioGenContraseña
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio final: Generador de contraseñas seguras
            /* de entre 8-20 caracteres
            * van  a contener al menos una mayúscula, una minúscula, un número y un carácter especial de entre 6 posibles opciones*/

            //variables necesarias

            string nombreUsuario, opcion, contraseña;

            //declaramos una tupla de nombre verificarContraseña para que reciba dos valores del metodo que valida la contraseña
            (bool contraseñaValida, string mensajeError) verificarContraseña;

            Console.WriteLine("\t\tRegistro\n\n");
             

            Console.Write("Ingrese su nombre de usuario: ");
            nombreUsuario = Console.ReadLine();

            Console.Write("Desea generar una contraseña segura? (si/no): ");
            opcion = Console.ReadLine().ToLower();


            //seguimos una de las dos rutas

            switch(opcion)
            {
                case "si":
                    Contraseña contraseña1 = new Contraseña(); //instanciamos la clase Contraseña

                    contraseña = contraseña1.GenerarContraseña(); //llamamos al método GenerarContraseña() de la clase Contraseña y guardamos el resultado en la variable contraseña

                    Console.WriteLine($"\n\nHola {nombreUsuario}, su contraseña segura es: {contraseña}"); //mostramos el mensaje con el nombre de usuario y la contraseña generada

                    Console.WriteLine("Pulsa cualquier tecla para salir...");
                    Console.ReadKey(); //esperamos a que el usuario pulse una tecla para salir del programa
                    Console.Clear(); //limpiamos la consola antes de salir

                    //RESUMEN datos

                    Console.WriteLine($"\nTus datos de acceso son los siguientes: \n\tNombre de usuario: {nombreUsuario} \n\tContraseña: {contraseña}"); //mostramos los datos de acceso

                    break;

                case "no":

                    Console.Write("\nIngrese una contraseña segura (la contraseña debe tener entre 8 y 20 caracteres, contener al menos una mayúscula, una minúscula, un número y un carácter especial): ");
                    contraseña = Console.ReadLine();

                    //insanciamos la clase Contraseña para poder usar el método ComprobarContraseña

                    Contraseña contraseña2 = new Contraseña(); //instanciamos la clase Contraseña


                    //llamamos al método ComprobarContraseña() de la clase Contraseña y guardamos el resultado en la tupla verificarContraseña

                    verificarContraseña = contraseña2.ComprobarContraseña(contraseña); //pasamos la contraseña ingresada por el usuario al método ComprobarContraseña


                    if (verificarContraseña.contraseñaValida)
                    {
                        Console.WriteLine($"\n\nHola {nombreUsuario}, su contraseña es válida: {contraseña}"); //si la contraseña es válida, mostramos el mensaje con el nombre de usuario y la contraseña ingresada
                        Console.WriteLine("Pulsa cualquier tecla para salir...");
                        Console.ReadKey(); //esperamos a que el usuario pulse una tecla para salir del programa
                        Console.Clear();
                    }
                    else
                    {
                        //usamos el segundo elemento de la tupla verificarContraseña para mostrar el mensaje de error

                        Console.WriteLine(verificarContraseña.mensajeError); //si la contraseña no es válida, mostramos el mensaje de error

                    }

                    break;



            }

        }

    }

        }


class Contraseña
{
    //campos
    // 4 colecciones de caracteres para escoger y generar la contraseña

    string numeros = "0123456789";
    string letrasMin = "abcdefghijklmnopqrstuvwxyz";
    string letrasMay = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string caracteresEspeciales = "$%#&!?";

    // contadores para verificar el numero de caracteres de cada grupo

    int numContiene = 0, minContiene = 0, mayContiene = 0, espContiene = 0;


    //metodo para generar la contraseña

    public string GenerarContraseña()
    {
        //aqui guardamos la contraseña



        StringBuilder contraseñaGenerada = new StringBuilder(); //usamos StringBuilder para construir la contraseña de manera eficiente

        //instanciamos el objeto Random para generar números aleatorios
        Random random = new Random();

        // declaramos una variable que guarda el tamaño que tendrá la contraseña
        int longitudContraseña = random.Next(8, 21); // longitud entre 8 y 20 caracteres


        //variables que van a determinar el numero de caracteres que se usaran en cada grupo. Basandose en un porcentaje de la longitud de la contraseña

        double numTener = longitudContraseña * 0.15; // 15% de los caracteres serán números
        double minTener = longitudContraseña * 0.35; // 35% de los caracteres serán letras minúsculas
        double mayTener = longitudContraseña * 0.35; // 35% de los caracteres serán letras mayúsculas
        double espTener = longitudContraseña * 0.15; // 15% de los caracteres serán caracteres especiales


        //variable de tipo char que va a almacenar a cada uno de los caracteres que van a conformar la contraseña
        char caracterEscogido;

        //iteracion While para ir colocando un caracter  (de los 4 del grupo) hasta que completemos la longitud que se establecio anteriormente

        while (contraseñaGenerada.Length < longitudContraseña)
        {
            switch (random.Next(0, 4))
            {
                case 0: //caracteres numéricos

                    if (numContiene < numTener) //verificamos que no se haya alcanzado el número de caracteres numéricos
                    {
                        caracterEscogido = numeros[random.Next(numeros.Length)];  //A caracterEscogido se le va a asignar un caracter aleatorio de los contenidos en el string "numeros", basándose en el indice y en la propiedad Length. Por ejem: caracterEscogido = numeros[3]; tomaria el cuarto caracter. caracterEscogido = numeros[random.Next(10)]; porque son 10 elementos

                        /*contraseñaGenerada += caracterEscogido;*/ //se acumula el caracter escogido en la contraseña generada

                        contraseñaGenerada.Append(caracterEscogido); //se acumula el caracter escogido en la contraseña generada usando StringBuilder

                        numContiene++; //se aumenta en 1 a los caracteres numéricos que contiene la contraseña generada
                    }
                    break;


                case 1:

                    if (minContiene < minTener) //verificamos que no se haya alcanzado el número de caracteres numéricos
                    {
                        caracterEscogido = letrasMin[random.Next(letrasMin.Length)];  //A caracterEscogido se le va a asignar un caracter aleatorio de los contenidos en el string "letrasMin", basándose en el indice y en la propiedad Length. Por ejem: caracterEscogido = letrasMin[3]; tomaria el cuarto caracter. caracterEscogido = letrasMin[random.Next(10)]; porque son 10 elementos
                        /*contraseñaGenerada += caracterEscogido;*/ //se acumula el caracter escogido en la contraseña generada
                        contraseñaGenerada.Append(caracterEscogido); //se acumula el caracter escogido en la contraseña generada usando StringBuilder
                        minContiene++; //se aumenta en 1 a los caracteres minúsculas que contiene la contraseña generada
                    }
                    break;

                case 2:

                    if (mayContiene < mayTener) //verificamos que no se haya alcanzado el número de caracteres mayúsculas
                    {
                        caracterEscogido = letrasMay[random.Next(letrasMay.Length)];  //A caracterEscogido se le va a asignar un caracter aleatorio de los contenidos en el string "letrasMay", basándose en el indice y en la propiedad Length. Por ejem: caracterEscogido = letrasMay[3]; tomaria el cuarto caracter. caracterEscogido = letrasMay[random.Next(10)]; porque son 10 elementos
                        /*contraseñaGenerada += caracterEscogido;*/ //se acumula el caracter escogido en la contraseña generada
                        contraseñaGenerada.Append(caracterEscogido); //se acumula el caracter escogido en la contraseña generada usando StringBuilder
                        mayContiene++; //se aumenta en 1 a los caracteres mayúsculas que contiene la contraseña generada
                    }

                    break;

                case 3:

                    if (espContiene < espTener) //verificamos que no se haya alcanzado el número de caracteres especiales
                    {
                        caracterEscogido = caracteresEspeciales[random.Next(caracteresEspeciales.Length)];  //A caracterEscogido se le va a asignar un caracter aleatorio de los contenidos en el string "caracteresEspeciales", basándose en el indice y en la propiedad Length. Por ejem: caracterEscogido = caracteresEspeciales[3]; tomaria el cuarto caracter. caracterEscogido = caracteresEspeciales[random.Next(10)]; porque son 10 elementos
                       /* contraseñaGenerada += caracterEscogido; *///se acumula el caracter escogido en la contraseña generada
                        contraseñaGenerada.Append(caracterEscogido); //se acumula el caracter escogido en la contraseña generada usando StringBuilder
                        espContiene++; //se aumenta en 1 a los caracteres especiales que contiene la contraseña generada
                    }
                    break;






            }



        }
        return contraseñaGenerada.ToString(); //retornamos la contraseña generada
    }


    public (bool, string) ComprobarContraseña(string contraseñaPa)
    {

        bool contraseñaValida = false; //inicializamos la variable que va a determinar si la contraseña es válida o no (comprueba todas las carac.)

        //variables para cada criterio de la contraseña
        bool hayNumero = false, hayMinuscula = false, hayMayuscula = false, hayEspecial = false;

        //variable para guardar el mensaje de error

        string mensajeError = "";

        //Verificar que se cumpla la longitud de la contraseña
        if (contraseñaPa.Length >= 8 && contraseñaPa.Length <= 20)
        {
            //verificar que contenga al menos un número
            foreach (char elemento in numeros)
            {
                // si el elemento numeros se encuentra en la contraseña, se ingresa al if y "esNumero" se pone en true
                if (contraseñaPa.IndexOf(elemento) >= 0)
                {
                    hayNumero = true;
                    break; //la instruccion fuerza la terminacion del foreach en el momento que se encuentra un número. Significa que if se cumple.
                }
                else
                {
                    hayNumero = false; //si no se encuentra un número, se pone en false
                    mensajeError = "La contraseña debe contener al menos un número.\n"; //se agrega el mensaje de error
                }
            }

            //verificamos que haya existido un numero en la contraseña
            if (hayNumero)
            {
                //verificar que contenga al menos una letra mayúscula
                foreach (char elemento in letrasMay)
                {
                    if (contraseñaPa.IndexOf(elemento) >= 0)
                    {
                        hayMayuscula = true;
                        break; // la instruccion fuerza la terminacion del foreach en el momento que se encuentra una letra mayuscula. Significa que if se cumple.
                    }
                    else
                    {
                        hayMayuscula = false; //si no se encuentra una letra mayuscula, se pone en false
                        mensajeError = "La contraseña debe contener al menos una letra mayúscula.\n"; //se agrega el mensaje de error CORREGIDO
                    }
                }

                //verificamos que haya existido una mayúscula en la contraseña
                if (hayMayuscula) // CORREGIDO: era hayMinuscula, ahora es hayMayuscula
                {
                    //verificamos que contenga al menos una letra minúscula
                    foreach (char elemento in letrasMin)
                    {
                        if (contraseñaPa.IndexOf(elemento) >= 0)
                        {
                            hayMinuscula = true;
                            break; // la instruccion fuerza la terminacion del foreach en el momento que se encuentra una letra minuscula. Significa que if se cumple.
                        }
                        else
                        {
                            hayMinuscula = false; //si no se encuentra una letra minuscula, se pone en false
                            mensajeError = "La contraseña debe contener al menos una letra minúscula.\n"; //se agrega el mensaje de error CORREGIDO
                        }
                    }
                }

                //verificamos que haya existido una minúscula en la contraseña
                if (hayMinuscula) // CORREGIDO: era hayMayuscula, ahora es hayMinuscula
                {
                    //verificamos que contenga un caracter especial
                    foreach (char elemento in caracteresEspeciales)
                    {
                        if (contraseñaPa.IndexOf(elemento) >= 0)
                        {
                            hayEspecial = true;
                            break; // la instruccion fuerza la terminacion del foreach en el momento que se encuentra un caracter especial. Significa que if se cumple.
                        }
                        else
                        {
                            hayEspecial = false; //si no se encuentra un caracter especial, se pone en false
                            mensajeError = "La contraseña debe contener al menos un caracter especial.\n"; //se agrega el mensaje de error
                        }
                    }
                }
            }
        }

        //verificamos que exista un numero, una letra minuscula, letra mayuscula y un caracter especial

        if (hayNumero && hayMinuscula && hayMayuscula && hayEspecial)
        {
            contraseñaValida = true; //si se cumplen todos los criterios, la contraseña es válida
        }
        else
        {
           
            contraseñaValida = false; //si no se cumple alguno de los criterios, la contraseña no es válida
        }

        // devolvemos el resultado de la comprobación y el mensaje de error (si lo hay)
        return (contraseñaValida, mensajeError);//retornamos una tupla con el resultado de la comprobación y el mensaje de error
    }



}