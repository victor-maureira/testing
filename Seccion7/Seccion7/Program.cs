using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Seccion7
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //variable local

//           // bool acelerar = true;

//            //instanciando a la clase Automovil
//            Automovil automovil1 = new Automovil();

//            //mostramos campo privado
//            //Console.WriteLine($"el color es {automovil1.Color}");


//            //asignando un valor al campo privado y mostrandolo
//            automovil1.Combustible = "Diesel";
//            //Console.WriteLine($"el combustible es {automovil1.Combustible}");

//            Console.WriteLine(automovil1.ToString());

//        }


//        //declaracion de un campo
//        int numero;
//    }


//    // [modificador de acceso] [class] [identificador]

//    public class Automovil
//    {
//        //campos
//        private string color = "rojo", modelo, combustible;
//        private byte año, numPuertas;
//        private int ccMotor;

//        //ejemplo de campos inicializados con el constructor
//        private string asientos, colorTablero;
//        private bool camaraTrasera;

//        //constructor
//        public Automovil()
//        {
//            asientos = "Piel";
//            colorTablero = "Rojo";
//            camaraTrasera = true;


//        }



//        //propiedades
//        // acceso, tipo y nombre

//        public string Color
//        {
//            //descriptor de acceso get
//            get => color;

//        }

//        public string Combustible
//        {
//            //descriptor de acceso get
//            get => combustible;

//            //descriptor de acceso set
//            set => combustible = value;
//        }

//        //metodos
//        public bool Acelerar()
//        {
//            bool acelerando = true;
//            Console.WriteLine("Acelerando...");
//            Prueba(); //llamando al metodo estatico
//            return acelerando;
//        }

//        public bool Frenar()
//        {
//            bool frenando = true;
//            Console.WriteLine("frenando");
//            return frenando;
//        }

//        public void Velocidades(ref byte velocidadPa)
//        {
//            velocidadPa++;
//            Console.WriteLine("cambio de velocidad");
//        }

//        //metodo estatico
//        public static void Prueba()
//        {
//            Console.WriteLine("Metodo estatico de la clase Automovil");
//        }

//        //invalidando el metodo ToString

//        public override string ToString()
//        {
//            string mensaje;
//            mensaje = $"Color: {color} \nModelo: {modelo} \nCombustible: {combustible} \nAño: {año} \nNumero de Puertas: {numPuertas} \nCC Motor: {ccMotor},Asientos: {asientos}, ";

//            return mensaje;
//        }

//    }

//}



namespace Seccion7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables locales
            string nombreAr, apellidoAr, nip;

            Console.WriteLine("Bienvenido al sistema de empleados\n");
            Console.WriteLine("Ingrese los siguientes campos que se le solicitan:\n ");

            Console.Write("Nombre: ");
            nombreAr = Console.ReadLine();

            Console.Write("Apellido: ");
            apellidoAr = Console.ReadLine();

            Console.Write("NIP: ");
            nip = Console.ReadLine();

            //instanciando a la clase Empleado

            Empleado empleado1 = new Empleado(nombreAr, apellidoAr);

            empleado1.Nip = nip; //asignando el nip al empleado


            //mostrar la informacion del objeto

            Console.WriteLine(empleado1.ToString());






        }

    }


    class Empleado
    {
        //campos
        private string nombre, apellido, id, locker, banco, nip;


        //constructor
        public Empleado(string nombrePa, string apellidoPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;

            //llamando a los metodos para generar los numeros aleatorios
            id = GenerarId();
            locker = GenerarLocker();
            banco = AsignarBanco();
        }

        //instanciamos a random
        Random random = new Random();


        //propiedades
        public string Nip
        {
            set => nip = value;
        }


        //metodos

        private string GenerarId()
        {
       
            int i, numero;

            string id = "";

            for (i = 0; i < 10; i++)
            {
                numero = random.Next(10); //generamos un numero aleatorio entre 0 y 9

                id += numero.ToString(); //concatenamos el numero al id
            }

            return id;
        }



        private string GenerarLocker()
        {
         
            int i, numero;

            string locker = "";

            for (i = 0; i < 2; i++)
            {
                numero = random.Next(10); //generamos un numero aleatorio entre 0 y 9

                locker += numero.ToString(); //concatenamos el numero al id
            }

            return locker;
        }



        private string AsignarBanco()
        {
    

            //variables
            int asignarBanco;
            string banco = "";

            asignarBanco = random.Next(1, 3); //generamos un numero aleatorio entre 1 y 2

            switch (asignarBanco)
            {
                case 1:
                    banco = "Santander";
                    break;

                case 2:
                    banco = "BBVA";
                    break;
            }
            return banco;
        }

        public override string ToString()
        {
            string mensaje = " ";

            mensaje = $"Nombre: {nombre} \nApellido: {apellido} \nID: {id} \nLocker: {locker} \nBanco: {banco} \nNIP: {nip}";

            return mensaje;
        }


    }

}