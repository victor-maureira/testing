using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Introducir una cadena de caracteres e indicar si es un palíndromo. Una palabra palíndroma es aquella que se lee igual adelante que atrás. Por ejemplo: ojo, rayar, solos.

Hacer un programa que le pida al usuario la fecha de su nacimiento, y nosotros le diremos qué día de la semana era.

Modificar ligeramente al programa “Generador de contraseñas” y a su método “GenerarContraseña” para que haga uso de StringBuilder en la concatenación de  la contraseña que se está generando.*/


namespace Tarea9
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // le pedimos al usuario su fecha de nacimiento y le decimos qué día de la semana era   

            Console.WriteLine("Introduce tu fecha de nacimiento para indicarte en que mes naciste: (dia mes año)");
            string fechaNacimiento = Console.ReadLine();


            DateTime dateFechaNacimiento;

            dateFechaNacimiento = DateTime.Parse(fechaNacimiento);

            Console.WriteLine($"Naciste un {dateFechaNacimiento.ToString("dddd")}");





        }
    }


    //hacemos lo mismo pero con una clase palindromo

    class Palindromo
    {
        public string Palabra { get; set; }
        public Palindromo(string palabra)
        {
            Palabra = palabra;
        }
        public bool EsPalindromo()
        {
            string cadenaVacia = "";
            foreach (char caracter in Palabra)
            {
                cadenaVacia = caracter + cadenaVacia;
            }
            return cadenaVacia.Equals(Palabra, StringComparison.OrdinalIgnoreCase);
        }
    }







}
