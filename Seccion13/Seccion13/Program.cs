using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        // arreglo de tipo int, bidimensional
        static int[,] tablero = new int[3, 3]; //3 filas y 3 columnas

        //arreglo para simbolos del tablero
        static char[] simbolo = { ' ' , 'O', 'X'};


        static void Main(string[] args)
        {
            bool terminado = false;

            DibujarTablero();
            Console.WriteLine(" Jugador 1 = O\n Jugador 2 = X");

            do
            {
                //Turno al jugador 1
                PreguntarPosicion(1);

                //dibujar casilla que escoge el jugador 1
                DibujarTablero();

                //comprobar si ha ganado la partida el jugador 1
                terminado = ComprobarGanador();

                if (terminado == true)
                {
                    Console.WriteLine("¡El jugador 1 ha ganado!");
                }
                else //de lo contrario, comprobamos si hubo un empate
                {
                    terminado = ComprobarEmpate();
                    if (terminado == true)
                    {
                        Console.WriteLine("Esto es un empate.");
                    }

                    // si jugador 1 no gano, ni tampoco hubo empate entonces es turno del jugador 2 
                    else
                    {
                        //turno del jugador 2
                        PreguntarPosicion(2);

                        //dibujar la casilla del jugador 2
                        DibujarTablero();

                        // comprobar si ha ganado la partida el jugador2

                        terminado = ComprobarGanador();

                        if (terminado == true)
                        {
                            Console.WriteLine("El jugador 2 ha ganado!");
                        }
                    }
                }


                //repetir hasta 3 en linea o empate
            } while (terminado == false);


        }//cierre Main


        static void DibujarTablero()
        {
            //variables conteo del ciclo
            int fila = 0;
            int columna = 0;

            Console.WriteLine(); //ESPACIO antes de dibujar el tablero

            Console.WriteLine("-------------"); //dibujar primera linea horizontal

            for (fila = 0; fila < 3; fila++)
            {
                Console.Write("|");    //dibuja segunda linea horizontal

                for (columna = 0; columna < 3; columna++)
                {
                    //asigna un ' ', X o O segun corresponda
                    Console.Write($" {simbolo[tablero[fila, columna]]} |");
                }
                Console.WriteLine();
                Console.WriteLine("-------------"); //dibujar lineas horizontales

            }

        }

        //se encarga de preguntar donde escribir y lo dibuja en el tablero
        static void PreguntarPosicion(int jugador)
        {
            int fila, columna;
            do
            {
                Console.WriteLine();
                Console.WriteLine($"Turno del jugador: {jugador}");
                //pedimos el numero de fila
                do
                {
                    Console.Write("Seleciona la fila (1 a 3): ");
                    fila = Convert.ToInt32(Console.ReadLine());


                } while ((fila < 1) || (fila > 3)); //

                //pedimos el numero de columna
                do
                {
                    Console.Write("Seleciona la columna (1 a 3): ");
                    columna = Convert.ToInt32(Console.ReadLine());


                } while ((columna < 1) || (columna > 3));


                if (tablero[fila -1, columna -1] != 0 )
                {
                    Console.WriteLine("Casilla Ocupada.");
                }


            } while (tablero[fila - 1, columna - 1] != 0);

            //Si todo es correcto, se le asigna al jugador correspondiente

            tablero[fila - 1, columna - 1] = jugador;
        }

        //devuelve un valor de true si hay 3 en linea
        static bool ComprobarGanador()
        {
            int fila = 0;
            int columna = 0;
            bool ticTacToe = false;

            //si en alguna fila, todas las casillas son iguales  y no estan vacias
            for (fila = 0; fila < 3; fila++)
            {
                if ( (tablero[fila,0] == tablero[fila,1]) && (tablero[fila,0] == tablero[fila,2]) && (tablero[fila,0] != 0) )
                {
                    ticTacToe = true;
                }
            }

            //si en alguna fila, todas las casillas son iguales  y no estan vacias
            for (columna = 0; columna < 3; columna ++)
            {
                if ( (tablero[0, columna] == tablero[1, columna]) && (tablero[0, columna] == tablero[2, columna]) && (tablero[0, columna] != 0)      )
                {
                    ticTacToe = true;
                }
            }

            //si en alguna diagonal todas las casillas son iguales y no están vacias

            if ( (tablero[0,0] == tablero[1,1]) && (tablero[0,0] == tablero[2,2]) && (tablero[0,0] != 0) )
            {
                ticTacToe = true;
            }

            if ( (tablero[0,2] == tablero[1,1]) && (tablero[0,2] == tablero[2,0]) && (tablero[0,2]  != 0) )
            {
                ticTacToe = true;
            }


            return ticTacToe;



        }

        //metodo devuelve el valor de true si hay un empate
        static bool ComprobarEmpate()
        {
            bool hayEspacio = false;
            int fila = 0;
            int columna = 0;

            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3 ; columna++)
                {
                    if (  tablero[fila,columna] == 0 ) //si encuentra una sola casilla vacia, quiere decir que aun se puede seguir jugando
                    {
                        hayEspacio = true;
                    }
                }
            }

            return !hayEspacio;
            //si el ciclo anterior nos regresa un true, indicandonos que si hay espacios, entonces se tiene que regresar una negacion de true para que la condicion de empate no se cumpla en la funcion de main
        }
    }
}
