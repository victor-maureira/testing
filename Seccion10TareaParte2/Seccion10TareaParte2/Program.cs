using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion10TareaParte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompraBoletos comprarBoletos = new CompraBoletos();
            comprarBoletos.Reservacion();
        }
    }









    class CompraBoletos
    {
        //Campos
        Destinos destinoEscogido;
        Horarios horarioEscogido;
        SeccionAvion seccionEscogida;
        TipoAsiento asientoEscogido;

        int precioBase;
        int precioSeccion;
        int precioAsiento;
        int precioFinal;



        public void Reservacion()
        {
            Console.Clear();

            Console.WriteLine("\n\t\tBienvenido/a a la reserva de vuelos.\n\t\t");

            //Creamos un objeto cliente para guardar su informacion
            Cliente cliente = new Cliente();

            //Pedimos Informacion
            Console.WriteLine("Ingrese la informacion que se solicita a continuación\n");

            Console.Write("Nombre: ");
            cliente.Nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            cliente.Apellido = Console.ReadLine();

            Console.Write("Id de Identificacion: ");
            cliente.Id = Console.ReadLine();

            Console.Write("Edad: ");
            cliente.Edad = Convert.ToInt32(Console.ReadLine());

            SeleccionarDestino();
            SeleccionarHorario();
            SeleccionarSeccion();
            SeleccionarAsiento();
            ResumenReservacion(cliente);


        }




        public void SeleccionarDestino()
        {
            //Variables
            int indice = 1;
            int opcionDestino;

            Console.WriteLine("\nDestinos Disponibles\n");

            foreach (Destinos elemento in Enum.GetValues(typeof(Destinos)))
            {
                Console.WriteLine($"{indice++}. {elemento} - ${(int)elemento}");
                
            }

            Console.Write("Seleccione un destino: ");
            opcionDestino = Convert.ToInt32(Console.ReadLine());


            switch (opcionDestino)
            {
                case 1:
                    destinoEscogido = Destinos.Guadalajara;
                    precioBase = (int)destinoEscogido;
                    break;
                case 2:
                    destinoEscogido = Destinos.Monterrey;
                    precioBase = (int)destinoEscogido;
                    break;

                case 3:
                    destinoEscogido = Destinos.LosAngeles;
                    precioBase = (int)destinoEscogido;
                    break;

                default:
                    Console.WriteLine("Opcion no valida, intente nuevamente.");
                    break;
            }
        }

        public void SeleccionarHorario()
        {
            //Variables
            int indice = 1;
            int opcion;

            //solicitamos el horario al pasajero

            Console.WriteLine("\nHorarios Disponibles\n");

            foreach (Horarios elemento in  Enum.GetValues(typeof(Horarios)))
            {
                Console.Write($"{indice++}. {(int)elemento}:00\n");
            }

            Console.Write("Seleccione un horario (indice): ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    horarioEscogido = Horarios.Siete_AM;
                    
                    break;

                case 2:
                    horarioEscogido = Horarios.Tres_PM;

                    break;

                case 3:
                    horarioEscogido = Horarios.Ocho_PM;

                    break;

                default:
                    Console.WriteLine("\nHorario no disponible o inválido.");
                    break;
            }

        }

        public void SeleccionarSeccion()
        {
            //Variables
            int indice = 1;
            int opcionSeccion;

            Console.WriteLine("\nSecciones Disponibles\n");

            foreach (SeccionAvion elemento in Enum.GetValues(typeof(SeccionAvion)))
            {
                Console.WriteLine($"{indice++}. {elemento} - ${(int)elemento}");

            }

            Console.Write("Seleccione una seccion (indice): ");
            opcionSeccion = Convert.ToInt32(Console.ReadLine());

            switch (opcionSeccion)
            {
                case 1:
                    seccionEscogida = SeccionAvion.Atras;
                    precioSeccion = (int)seccionEscogida;
                    break;


                case 2:
                    seccionEscogida = SeccionAvion.Centro;
                    precioSeccion = (int)seccionEscogida;
                    break;

                case 3:
                    seccionEscogida = SeccionAvion.Adelante;
                    precioSeccion = (int)seccionEscogida;
                    break;

                default:
                    Console.WriteLine("Seccion no válida.");
                    break;
            }

        }


        public void SeleccionarAsiento()
        {

            //Variables
            int indice = 1;
            int opcionAsiento;

            Console.WriteLine("\nAsientos Disponibles\n");

            foreach (TipoAsiento elemento in Enum.GetValues(typeof(TipoAsiento)))
            {
                Console.WriteLine($"{indice++}. {elemento} - ${(int)elemento}");

            }

            Console.Write("Seleccione un asiento (indice): ");
            opcionAsiento = Convert.ToInt32(Console.ReadLine());


            switch(opcionAsiento)

            {
                case 1:
                    asientoEscogido = TipoAsiento.Medio;
                    precioAsiento = (int)asientoEscogido;
                    break;

                case 2:
                    asientoEscogido = TipoAsiento.Pasillo;
                    precioAsiento = (int)asientoEscogido;
                    break;

                case 3:
                    asientoEscogido = TipoAsiento.Ventana;
                    precioAsiento = (int)asientoEscogido;
                    break;

                default:
                    Console.Write("Asiento no válido.");
                    break;


            }

        }

        public void ResumenReservacion(Cliente clientePa)
        {
            Console.Clear();

            //Resumen

            Console.WriteLine("\n\t\tResumen de la Reserva\n\t\t");

            Console.WriteLine($"Nombre: {clientePa.Nombre} {clientePa.Apellido}");
            Console.WriteLine($"Edad: {clientePa.Edad}");
            Console.WriteLine($"Numero de identificacion: {clientePa.Id}");

            Console.WriteLine($"Destino Escogido: {destinoEscogido} ${(int)destinoEscogido}");
            Console.WriteLine($"Horario: {(int)horarioEscogido}:00");
            Console.WriteLine($"Seccion: {seccionEscogida}: ${(int)seccionEscogida}");
            Console.WriteLine($"Asiento: {asientoEscogido}: ${(int)asientoEscogido}");
            Console.WriteLine($"Precio Final: {precioFinal = precioBase + precioSeccion + precioAsiento}");

            Console.WriteLine("Confirme su reservación.");
            Console.ReadKey();

        }


    }


    struct Cliente
    {
        string nombre;
        string apellido;
        string id;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Id { get => id; set => id = value; }
        public int Edad { get => edad; set => edad = value; }
    }


    enum Destinos {Guadalajara = 900, Monterrey = 1000, LosAngeles = 1700 }
    enum Horarios {Siete_AM = 07, Tres_PM = 15, Ocho_PM = 20 }
    enum SeccionAvion {Atras = 0 , Centro = 50 , Adelante = 80 }
    enum TipoAsiento {Medio = 20, Pasillo = 60, Ventana = 90}

}
