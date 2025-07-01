using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion10TareaParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables

            bool repetir = true; //Se encarga de repetir el menu hasta que nosotros salir del programa
            int opcion;

            //instanciamos la clase inventario para poder usarla
            Inventario inventario = new Inventario();

            do
            {
                Console.Clear();

                Console.WriteLine("\n\t\t Tarea 10 \n\t\t");
                Console.WriteLine("1. Agregar Producto");
                Console.WriteLine("2. Mostrar Inventario");
                Console.WriteLine("3. Elimina Producto");
                Console.WriteLine("4. Salir");

                Console.Write("\nIngrese una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        inventario.AgregarProducto();
                        break;

                    case 2:
                        inventario.MostrarProducto();
                        break;

                    case 3:
                        inventario.EliminarProducto();
                        break;

                    case 4:
                        repetir = false;
                        break;

                    default:
                        Console.WriteLine("\n\t\aLa opción ingresada no es válida, intente nuevamente.\n\t");
                        break;
                }


            } while (repetir);

        }
    }



    class Inventario
    {
        //campos
        //Se crea una lista de productos para almacenar el inventario

        List<Celular> listaCelulares = new List<Celular>();


        //metodos

        public void AgregarProducto()
        {
            //Creamos un nuevo producto (objeto) de tipo celular
            Celular nuevoProducto = new Celular();

            Console.Clear();
            Console.WriteLine("\n\t\tAgregar Producto\t\t\n");

            //Preguntamos los valores que tendra el producto y asignamos:

            Console.Write("Marca: ");
            nuevoProducto.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            nuevoProducto.Modelo = Console.ReadLine();

            Console.Write("Memoria Principal: ");
            nuevoProducto.MemoriaPrincipal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Precio: ");
            nuevoProducto.Precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Stock: ");
            nuevoProducto.Stock = Convert.ToInt32(Console.ReadLine());

            //agregamos el producto "celular" a la list
            listaCelulares.Add(nuevoProducto);

            Console.Write("Se ha agregado el producto al inventario. Pulse cualquier tecla para continuar...");
            Console.ReadKey();


        }

        public void MostrarProducto()
        {
            Console.Clear();

            if (listaCelulares.Count == 0)
            {
                Console.Write("El inventario está vacio.");
            }
            else
            {
                int indice = 1;
                Console.WriteLine("\n\t\tInventario de Productos\t\t\n");

                foreach(Celular elemento in listaCelulares)
                {
                    Console.WriteLine($"{indice}: \nMarca: {elemento.Marca} \nModelo: {elemento.Modelo} \nMemoria: {elemento.MemoriaPrincipal} \nPrecio: {elemento.Precio} \nStock: {elemento.Stock}");
                    indice++;
                }

                Console.Write("\nPulsa cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        public void EliminarProducto()
        {
            //variable para indicar el indice a eliminar
            int productoEliminar;

            Console.Clear();
            if (listaCelulares.Count == 0)
            {
                Console.WriteLine("No hay ningún producto para eliminar.");
            }
            else
            {
                Console.Write($"Ingrese el indice del producto a eliminar (del 1 al {listaCelulares.Count}): ");
                productoEliminar = Convert.ToInt32(Console.ReadLine()) - 1; //reducir en 1 para que el indice ingresado coincida con el de la lista.

                if (productoEliminar >= 0 && productoEliminar < listaCelulares.Count)
                {
                    //Preguntamos para confirmar la eliminacion del producto.

                    Console.Write($"Desea eliminar \"{listaCelulares[productoEliminar].Marca}, {listaCelulares[productoEliminar].Modelo}\"? (Si/No)");
                    string opcion = Console.ReadLine().ToLower();

                    if (opcion == "si")
                    {
                        //variables para mostrar la marca y modelo eliminado

                        string marcaEliminado = listaCelulares[productoEliminar].Marca;
                        string modeloEliminado = listaCelulares[productoEliminar].Modelo;

                        //eliminamos el producto
                        listaCelulares.RemoveAt(productoEliminar);

                        //Mostramos un mensaje diciendo que el producto fue eliminado

                        Console.WriteLine($"El producto {marcaEliminado}, {modeloEliminado} ha sido eliminado exitosamente.");

                    }
                    else
                    {
                        Console.Write("Operacion Cancelada.");
                    }

                }
                else
                {
                    Console.Write("El indice ingresado no es válido, revisa la lista nuevamente.");
                }
            }

            Console.Write("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
        }

    }








    struct Celular
    {
        //Campos

        private string marca;
        private string modelo;
        private int memoriaPrincipal;
        private double precio;
        private int stock;

        //propiedades
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int MemoriaPrincipal { get => memoriaPrincipal; set => memoriaPrincipal = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
