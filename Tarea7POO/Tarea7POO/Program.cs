using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables locales
            string nombrePa, apellidoPa, direccionPa, pinPa;
            double saldoPa, retiroPa;
            int opcion;


            //solicitamos los datos

            Console.WriteLine("Ingrese su nombre: ");
            nombrePa = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellidoPa = Console.ReadLine();
            Console.WriteLine("Ingrese su dirección: ");
            direccionPa = Console.ReadLine();
            Console.WriteLine("Digite su PIN:");
            pinPa = Console.ReadLine();

            Console.WriteLine("Digite un saldo inicial para su cuenta:");
            saldoPa = Convert.ToDouble(Console.ReadLine());

            //instanciamos la clase

            CuentaBancaria cuentabancaria1 = new CuentaBancaria(nombrePa, apellidoPa,  saldoPa, direccionPa, pinPa);



            //creacion menu con do-while

            do
            {
                Console.WriteLine($"Bienvenido {nombrePa} al menú del banco. Por favor, seleccione una opción:");
                Console.Write("1. Deposito\n 2. Retiro \n3. Consultar saldo \n4. Mostrar información de la cuenta \n5. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());


                //switch

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese monto a depositar: ");
                        double montoDeposito = Convert.ToDouble(Console.ReadLine());
                        cuentabancaria1.Deposito(montoDeposito);
                        break;


                    case 2:
                        Console.Write("Cuanto dinero desea retirar?: ");
                        retiroPa = Convert.ToDouble(Console.ReadLine());

                        cuentabancaria1.Retiro(retiroPa);
                        break;

                    case 3:
                        cuentabancaria1.ConsultaSaldo();
                        break;

                    case 4:
                        Console.WriteLine(cuentabancaria1.ToString());
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del menú...");
                        break;

                    default:
                        Console.WriteLine("Error.");
                        break;

                }

            } while (opcion != 5);

            

            



        }
    }







    //Creo clase CuentaBancaria

    class CuentaBancaria
    {

        //campos

        private string nombre, apellido, direccion, pin;
        private double saldo;

        //constructor

        public CuentaBancaria(string nombrePa, string apellidoPa, double saldoPa, string direccionPa, string pinPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;
            saldo = saldoPa;
            direccion = direccionPa;
            pin = pinPa;
           

         

        }


        //metodos

        //metodo deposito que se encarga de recibir un dinero del exterior y sumarlo al saldo
        public double Deposito(double montoPa)
        {
            saldo += montoPa;
                return saldo;
        }

        //metodo para consultar cual es el saldo  de nuestra cuenta bancaria
        public void ConsultaSaldo()
        {
            Console.WriteLine(saldo);
        }

        //metodo que se encarga de extraer una suma de dinero del campo "saldo" dada desde el exterior (verificar que sea posible retirar el dinero a partir del saldo de la cuenta
        public double Retiro(double montoPa)
        {
           

            if (saldo < montoPa)
            {
                Console.WriteLine("No tienes fondos suficientes");
                return saldo;
            }
            else
            {
                saldo -= montoPa;
                Console.WriteLine($"Tu nuevo saldo es:{saldo}");
            }

            return saldo;
        }


        public override string ToString()
        {
            string mensaje = " ";

            mensaje = $"Nombre: {nombre}\n Apellido: {apellido}\n Direccion: {direccion}\n Pin: {pin}\n Saldo: {saldo}\n";

            return mensaje;
        }
       






    }




}
