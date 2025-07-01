using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion10EnumEj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RPG

            //variables
            string nombreJugador1, nombreJugador2;
            int primerTurno;

            Console.Write("Jugador 1, ingresa tu nombre: ");
            nombreJugador1 = Console.ReadLine();

            //instanciamos a la clase jugador, creamos al primer jugador y enviamos su nombre y salud inicial

            Jugador jugador1 = new Jugador(nombreJugador1, 1000);

            //le preguntamos al jugador que personaje y arma escogerá

            jugador1.SeleccionPersonaje();
            jugador1.EscogerArma();


            Console.Write("Jugador 2, ingresa tu nombre: ");
            nombreJugador2 = Console.ReadLine();

            //instanciamos a la clase jugador, creamos al primer jugador y enviamos su nombre y salud inicial

            Jugador jugador2 = new Jugador(nombreJugador2, 1000);

            //le preguntamos al jugador que personaje y arma escogerá

            jugador2.SeleccionPersonaje();
            jugador2.EscogerArma();

            //llamamos al metodo tirardados y asignamos el valor aleatorio en primerTurno
            primerTurno = Batalla.TirarDados();

            //determinamos que jugador comenzará primero
            if (primerTurno == 1)
            {
                //Jugador 1 comenzará
                Console.WriteLine($"El {jugador1.Nombre} comienza primero!");

                //invocamos al metodo simularbatalla para que el jugador1 realice el primer ataque

                Batalla.SimularBatalla(jugador1, jugador2);
            }
            else
            {
                //jugador 2 comienza
                Console.WriteLine($"El {jugador2.Nombre} comienza primero.");

                //el jugador realiza el primer ataque

                Batalla.SimularBatalla(jugador2, jugador1);
            }

        }
    }


    enum TipoPersonaje {Arquero, Caballero, Mago }


    enum TipoArma { Espada, Arco, Baston}


    class Jugador
    {
        //campos
        string nombre;
        int salud;
        int ataque;
        int defensa;

        TipoPersonaje personajeEscogido;
        TipoArma armaEscogida;

        //instanciamos a la clase Random para hacer uso de ella en el metodo CalcularDaño

        Random random = new Random();

        // propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        internal TipoPersonaje PersonajeEscogido { get => personajeEscogido; set => personajeEscogido = value; }
        internal TipoArma ArmaEscogida { get => armaEscogida; set => armaEscogida = value; }


        //constructor

        public Jugador(string nombrePa, int saludPa)
        {
            nombre = nombrePa;
            salud = saludPa;
        }

        //método que permite escoger un personaje

        public void SeleccionPersonaje()
        {
            int opcion;

            Console.Clear();


            do
            {
                Console.WriteLine("1. Arquero");
                Console.WriteLine("2. Caballero");
                Console.WriteLine("3. Mago");

                Console.Write($"\n{nombre}, escoge un personaje:");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                switch (opcion)
                {
                    case 1:
                        personajeEscogido = TipoPersonaje.Arquero;
                        ResumenPersonaje();
                        break;

                    case 2:
                        personajeEscogido = TipoPersonaje.Caballero;
                        ResumenPersonaje();
                        break;

                    case 3:
                        personajeEscogido = TipoPersonaje.Mago;
                        ResumenPersonaje();
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada no es valida, inténtalo de nuevo.");
                        break;
                }

            } while (opcion < 1 || opcion > 3);

        }

        public void ResumenPersonaje()
        {
            //Resumen del personaje que escogió el jugador

            Console.WriteLine($"Hola, {nombre}. Tu personaje es \"{personajeEscogido}\"");


            Console.Write("\nPresiona cualquier tecla para continuar.");
            Console.ReadKey();

            Console.Clear();
        }


        public void EscogerArma()
        {
            int opcion;

            Console.Clear();

            do
            {
                Console.WriteLine("1. Espada (Ataque: 130, Defensa: 40");
                Console.WriteLine("2. Arco (Ataque: 140, Defensa: 30");
                Console.WriteLine("3. Bastón (Ataque 160, Defensa: 10");

                Console.Write($"{nombre}, escoge un arma.");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                switch (opcion)
                {
                    case 1:
                        armaEscogida = TipoArma.Espada;
                        ValoresAtaqueDefensaArma();
                        ResumenArma();
                        break;

                    case 2:
                        armaEscogida = TipoArma.Arco;
                        ValoresAtaqueDefensaArma();
                        ResumenArma();
                        break;

                    case 3:
                        armaEscogida = TipoArma.Baston;
                        ValoresAtaqueDefensaArma();
                        ResumenArma();
                        break;

                    default:
                        Console.WriteLine("Opcion ingresada no válida. Por favor, ingrese otra.");
                        break;

                }




            } while (opcion < 1 || opcion > 3);

        }


        public void ValoresAtaqueDefensaArma()
        {
            switch (ArmaEscogida)
            {
                case TipoArma.Espada:
                    Ataque = 130;
                    Defensa = 40;
                    break;

                case TipoArma.Arco:
                    Ataque = 140;
                    Defensa = 30;
                    break;

                case TipoArma.Baston:
                    Ataque = 160;
                    Defensa = 10;
                    break;
            }
        }


        public void ResumenArma()
        {
            Console.WriteLine($"{Nombre}, escogiste \"{armaEscogida}\"\n Poder de Ataque: [{Ataque}], poder de defensa: [{Defensa}]");

            Console.Write("Pulsa cualquier tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }


        //metodo para mostrar un mensaje cuando el jugador decida atacar
        public void Atacar()
        {
            Console.WriteLine($"\n¡{personajeEscogido} ({Nombre}) ataca con su {armaEscogida}!\n");
        } 

        public void Defender()
        {
            Console.WriteLine($"\n¡{PersonajeEscogido} ({Nombre}) se defiende!\n");
        }

        //metodo que le pregunta al jugador si desea atacar o defender
        public void EscogerAtacarDefender()
        {
            int opcion;


            do
            {
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Defender");

                Console.WriteLine($"\n{PersonajeEscogido} ({Nombre}), escoge una acción:");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Atacar();
                        break;

                    case 2:
                        Defender();
                        break;

                    default:
                        Console.WriteLine("Accion no válida.");
                        break;
                }


            }while (opcion < 1 || opcion > 2);
        }


        //metodo que muestra un resumen de los jugadores

        public void ResumenJugadores()
        {
            Console.WriteLine($"\n[{Nombre}, {PersonajeEscogido}; Salud: {Salud} / {ArmaEscogida}] Ataque: {Ataque}, Defensa: {Defensa}");

        }


        //método encargado de calcular el daño recibido por los jugadores en base al poder de ataque y defensa del arma.

        public void CalcularDaño(int ataqueOtroJugadorPa)
        {
            int dañoRecibido;

            //variable para recibir el valor sorpresa
            int ataqueSorpresa;

            //le asignamos un valor de ataque aleatorio usando Next

            ataqueSorpresa = random.Next(-15, 16);

            //Espada: ataque 130 y defensa 40
            //Arco: Ataque 140 y defensa 30

            dañoRecibido = ataqueOtroJugadorPa - Defensa + ataqueSorpresa;


            //reducimos la salud del jugador

            Salud -= dañoRecibido;

        }

    }

    class Batalla
    {
        //instanciamos a la clase Random
        static Random random = new Random();



        //metodo que determina que jugador comenzará primero

        public static int TirarDados()
        {
            Console.Write($"Presiona cualquier tecla para lanzar el dado y determina quien comienza...");
            Console.ReadKey();
            Console.Clear();

            //variable que guarda el valor de los dados
            int primerTurno; 
            //le asignamos a esta variable un valor de entre 1 y 2 para determinar que jugador empieza primero.
            primerTurno = random.Next(1, 3);

            return primerTurno;
        }


        public static void SimularBatalla(Jugador jugador1Pa, Jugador jugador2Pa)
        {
            //variable encargada de controlar las rondas de los jugadores 
            int ronda = 1;

            //mensaje inicial
            Console.WriteLine("¡La batalla ha comenzado!\n");
            Console.WriteLine($"RONDA: {ronda}\n");

            //Resumen de cada jugador
            jugador1Pa.ResumenJugadores();
            jugador2Pa.ResumenJugadores();

            //Primera ronda del primer jugador
            Console.WriteLine($"{jugador1Pa.PersonajeEscogido} ({jugador1Pa.Nombre}), ¡comienza a atacar!");
            Console.WriteLine($"pulsa cualquier tecla para utilizar tu {jugador1Pa.ArmaEscogida}");
            Console.ReadKey();
            jugador1Pa.Atacar();

            //calculamos el daño que el jugador 1 acaba de realizar al jugador 2
            jugador2Pa.CalcularDaño(jugador1Pa.Ataque);

            //Primera ronda del jugador 2
            //Se llama al metodo para atacar o defender
            jugador2Pa.EscogerAtacarDefender();

            //Calculamos el daño del jugador 2 hacia el jugador 1

            jugador1Pa.CalcularDaño(jugador2Pa.Ataque);

            //haremos lo mismo por 4 rondas más (total 5 rondas)

            for (ronda = 2; ronda <= 5; ronda++)
            {
                //mostramos la ronda que se está jugando
                Console.WriteLine($"RONDA: {ronda}\n");

                //mostramos el resumen de cada jugador

                jugador1Pa.ResumenJugadores();
                jugador2Pa.ResumenJugadores();

                //Le preguntamos al jugador que desea hacer
                jugador1Pa.EscogerAtacarDefender();

                //calculamos el daño que el jugador 1 le acaba de hacer al jugador 2
                jugador2Pa.CalcularDaño(jugador1Pa.Ataque);


                //le preguntamos al otro jugador que hará
                jugador2Pa.EscogerAtacarDefender();

                //calculamos el daño que el jugador realizará al otro
                jugador1Pa.CalcularDaño(jugador2Pa.Ataque);

                //espacio en blanco para despues de cada ronda
                Console.WriteLine();
            }

            Console.WriteLine("\n¡La batalla ha terminado!\n");

            //mostramos por ultima vez el resumen de los jugadores
            jugador1Pa.ResumenJugadores();
            jugador2Pa.ResumenJugadores();

            //determinamos quien ganó en base a su salud

            if (jugador1Pa.Salud > jugador2Pa.Salud)
            {
                Console.WriteLine($"El jugador {jugador1Pa.Nombre} ha ganado la batalla.");
            }
            else
            {
                Console.WriteLine($"El jugador {jugador2Pa.Nombre} ha ganado.");
            }
        }

    }



}
