using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Seccion10Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables tipo type

            Type tipodatoStruct = typeof(Libro);
            Type tipodatoClass = typeof(Biblioteca);

            //mostramos el name

            Console.WriteLine($"El tipo de dato es: {tipodatoStruct.Name}");

            //mostrando el namespace

            Console.WriteLine($"El namespace es: {tipodatoStruct.FullName}");

            //declarando matriz fieldinfo

            FieldInfo[] camposdatosStruct;

            //asignando la devolucion del método GetFields (una matriz con información de los campos) a nuestra matriz camposdatosStruct

            camposdatosStruct = tipodatoStruct.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine("Campos del tipo: \n");
            foreach (FieldInfo elemento in camposdatosStruct)
            {
                Console.WriteLine(elemento);
            }


            //mostrando info de la clase biblioteca

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"El nombre completo del tipo es {tipodatoClass.FullName}");

            //matrices donde se guarda la informacion obtenida por GetProperties y GetMethods

            MethodInfo[] metododatoClass;  //para métodos
            PropertyInfo[] propiedadesdatoClass;  //para propiedades

            //usamos a GetProperties para obtener la información de las propiedades de nuestra clase, y almacenamos su devolución en la matriz "propiedadesdatoClass"

            propiedadesdatoClass = tipodatoClass.GetProperties();
            
            //usamos a GetMethods para obtener la información de los métodos de nuestra clase y almacenamos la información devuelta en la matriz "metododatoClass

            metododatoClass = tipodatoClass.GetMethods();

            //recorriendo a la matriz propiedadesdatoClass para mostrar las propiedades de Biblioteca
            Console.WriteLine("Propiedades del tipo: \n");
            foreach (PropertyInfo elemento in propiedadesdatoClass)
            {
                Console.WriteLine(elemento);
            }

            //recorriendo matriz metododatoClass para mostrar los metodos de la clase Biblioteca
            Console.WriteLine("Propiedades del tipo: \n");
            foreach (MethodInfo elemento in metododatoClass)
            {
                Console.WriteLine(elemento);
            }





            ////variables

            //bool repetir = true; //variable para repetir el menu
            //string opcion; //variable para guardar la opcion del usuario

            ////creamos una instancia de la clase Biblioteca

            //Biblioteca biblioteca1 = new Biblioteca();

            //do
            //{
            //    Console.Write("\nBiblioteca\n\n");
            //    Console.Write("1. Agregar libro\n");
            //    Console.Write("2. Mostrar libros\n");
            //    Console.Write("3. Busqueda exacta de un libro\n");
            //    Console.Write("4. Busqueda parcial de un libro\n");
            //    Console.Write("5. Eliminar libro\n");
            //    Console.Write("6. Salir\n\n");

            //    Console.Write("\nIngrese una opcion: ");
            //    opcion = Console.ReadLine(); //leemos la opcion del usuario

            //    switch (opcion)

            //    {
            //        case "1": //opcion para agregar un libro
            //            biblioteca1.AgregarLibro();
            //            break;

            //        case "2": //opcion para mostrar los libros
            //            biblioteca1.MostrarLibro();
            //            break;

            //        case "3": //opcion para buscar un libro
            //            biblioteca1.BuscarLibro();
            //            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            //            Console.ReadKey(); //esperamos que el usuario presione una tecla para continuar
            //            break;

            //        case "4": //opcion para buscar un libro de manera parcial
            //            biblioteca1.BusquedaParcial();
            //            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            //            Console.ReadKey(); //esperamos que el usuario presione una tecla para continuar
            //            break;

            //        case "5": //opcion para eliminar un libro
            //            biblioteca1.EliminarLibro();
            //            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            //            Console.ReadKey(); //esperamos que el usuario presione una tecla para continuar
            //            break;

            //        case "6": //opcion para salir del programa
            //            repetir = false; //cambiamos la variable repetir a false para salir del menu
            //            Console.Clear();
            //            Console.WriteLine("Gracias por usar el programa. Hasta luego!");
            //            break;
            //        default: //si el usuario ingresa una opcion no valida
            //            Console.Clear();
            //            Console.WriteLine("Opcion no valida. Por favor ingrese una opcion del 1 al 6.");
            //            break;


            //    }
            //} while (repetir); //mientras la variable repetir sea verdadera, se repetira el menu


        }
    }





    class Biblioteca
    {
        //campos
        Libro[] libros; //matriz de tipo struct "libro"
        int cantidadLibros = 0; //cantidad de libros en la biblioteca (no tenemos libro al inicio)
        string buscarLibro;
        bool libroEncontrado;
        int posicionlibroEliminar;

        public Libro[] Libros { get => libros; set => libros = value; }
        public int CantidadLibros { get => cantidadLibros; set => cantidadLibros = value; }
        public string BuscarLibro1 { get => buscarLibro; set => buscarLibro = value; }
        public bool LibroEncontrado { get => libroEncontrado; set => libroEncontrado = value; }
        public int PosicionlibroEliminar { get => posicionlibroEliminar; set => posicionlibroEliminar = value; }


        //constructor

        public Biblioteca()

        {
            libros = new Libro[1000]; //inicializa la matriz de libros con 1000 elementos
        }



        public void AgregarLibro()
        {
            if (cantidadLibros < libros.Length) //verificar si hay espacio en la matriz 
            {
                Console.Clear();

                Console.WriteLine($"Ingresar informacion del libro {cantidadLibros + 1}"); //mostramos +1 para que el usuario vea el numero del libro que esta ingresando

                Console.Write("Ingrese el titulo del libro: ");
                libros[cantidadLibros].Titulo = Console.ReadLine(); //leemos el titulo del libro y lo guardamos en la matriz
                Console.Write("Ingrese el autor del libro: ");
                libros[cantidadLibros].Autor = Console.ReadLine(); //leemos el autor del libro y lo guardamos en la matriz
                Console.Write("Ingrese el año de publicacion del libro: ");
                libros[cantidadLibros].Anio = Convert.ToInt32(Console.ReadLine()); //leemos el año de publicacion del libro y lo guardamos en la matriz

                cantidadLibros++; //aumentamos la cantidad de libros en la biblioteca

                Console.Clear();

                Console.WriteLine("Libro agregado correctamente.");
            }
            else
            {
                               Console.Clear();
                Console.WriteLine("No hay espacio para agregar mas libros.");
            }
        }

        public void MostrarLibro()
        {
            Console.Clear();
            if (cantidadLibros == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca. Por favor agregue uno.");
            }
            else
            {
                Console.Write("Libros en la biblioteca:\n\n");
                for (int i = 0; i < cantidadLibros; i++)
                {
                    Console.WriteLine($"Libro {i + 1}:");
                    Console.WriteLine($"Titulo: {libros[i].Titulo}");
                    Console.WriteLine($"Autor: {libros[i].Autor}");
                    Console.WriteLine($"Año de publicacion: {libros[i].Anio}\n");

                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey(); //esperamos que el usuario presione una tecla para continuar
                Console.WriteLine();
            }
        }


        public void BuscarLibro()
        {
            Console.Clear();

            Console.Write("Ingrese el titulo del libro que desea buscar: ");
            buscarLibro = Console.ReadLine(); //leemos el titulo del libro que el usuario desea buscar

            libroEncontrado = false; //inicializamos la variable libroEncontrado en false

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.Equals(buscarLibro))
                {
                    Console.Write($"El libro \"{libros[i].Titulo}\", del autor \"{libros[i].Autor}\" y publicado en \"{libros[i].Anio}\" fue encontrado.");
                    libroEncontrado = true; //si el libro fue encontrado, cambiamos la variable libroEncontrado a true
                }
            }
           
            if (!libroEncontrado) // es lo mismo que if (libroEncontrado == false)
            {
                Console.Write("Libro no encontrado.");
                libroEncontrado = false; //si el libro no fue encontrado, cambiamos la variable libroEncontrado a false
            }

        }

        public void BusquedaParcial()
        {
            Console.Clear();
            Console.Write("Ingresa al menos una parte del titulo del libro o autor que deseas buscar: ");
            buscarLibro = Console.ReadLine().ToLower(); 

            libroEncontrado = false; //inicializamos la variable libroEncontrado en false

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.ToLower().Contains(buscarLibro) || libros[i].Autor.ToLower().Contains(buscarLibro))
                {
                    Console.WriteLine($"Libro encontrado: {libros[i].Titulo} de {libros[i].Autor}, publicado en {libros[i].Anio} en el indice {i + 1}");
                    libroEncontrado = true; //si el libro fue encontrado, cambiamos la variable libroEncontrado a true
                }
            }
            if (!libroEncontrado) // es lo mismo que if (libroEncontrado == false)
            {
                Console.WriteLine("No se encontraron libros con esa busqueda parcial.");
            }
        }

        public void EliminarLibro()
        {
            Console.Clear();
            if (cantidadLibros == 0)
            {
                Console.Write("No hay libros para eliminar.)");
                
            }
            else
            {
                Console.Write($"Ingrese el numero del libro que desea eliminar. (del 1 a {cantidadLibros}): ");
                posicionlibroEliminar = Convert.ToInt32(Console.ReadLine()) - 1; //leemos el numero del libro que el usuario desea eliminar y lo guardamos en la variable posicionlibroEliminar, restando 1 para que coincida con el indice de la matriz

             
                //verificamos si el numero ingresado sea valido
                if (posicionlibroEliminar >= 0 && posicionlibroEliminar < cantidadLibros)
                {
                    Console.Write($"El libro que deseas eliminar es \"{libros[posicionlibroEliminar].Titulo}\" de {libros[posicionlibroEliminar].Autor}\"? (Si/No):");
                    string opcion = Console.ReadLine().ToLower(); //leemos la opcion del usuario y la convertimos a minusculas para evitar errores de mayusculas/minusculas

                    if (opcion == "si")
                    {
                        //variables para mostrar el libro eliminado

                        string tituloEliminado = libros[posicionlibroEliminar].Titulo;
                        string autorEliminado = libros[posicionlibroEliminar].Autor;

                        for (int i = posicionlibroEliminar; i < cantidadLibros; i++)
                        {
                            libros[i] = libros[i + 1]; //desplazamos los libros hacia la izquierda para eliminar el libro seleccionado

                        }
                        cantidadLibros--; //disminuimos la cantidad de libros en la biblioteca por el que acabamos de eliminar

                        //le mostramos el libro eliminado

                        Console.WriteLine($"Libro eliminado correctamente: {tituloEliminado} de {autorEliminado}.");
                    }

                    else
                    {
                        Console.Write("Operacion cancelada. No se elimino ningun libro.");
                    }
                }
                else
                {
                    Console.WriteLine("El numero ingresado no es valido. Por favor ingrese un numero del 1 al {cantidadLibros}.");
                }
            }


        }
    }


    struct Libro

    {
        //campos
        string titulo;
        string autor;
        int anio;

        // propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Anio { get => anio; set => anio = value; }
    }



}
