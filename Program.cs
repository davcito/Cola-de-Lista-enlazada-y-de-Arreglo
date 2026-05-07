using Colas;
using System;
using System.Drawing;


namespace Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColaArreglo colaArreglo = new ColaArreglo();
            ColaLista colaLista = new ColaLista();

            int opcion;
            int valor;

            do
            {
                Console.WriteLine("Elige una opcion");
                Console.WriteLine("1. Usar Cola Arreglo");
                Console.WriteLine("2. Usar Cola Lista Enlazada");
                Console.WriteLine("3 Salir");


                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                    ColaArreglo(colaArreglo);
                if (opcion == 2)
                    ColaLista(colaLista);
                if (opcion == 3)
                    break;

                

            } while (opcion != 3);
        }
        public static void ColaArreglo(ColaArreglo cola)
        {
            int opcion = 0;
            int valor = 0;

            do
            {
                Console.WriteLine("Ingrese la operación que desea realizar: ");
                Console.WriteLine("1 Encolar ");
                Console.WriteLine("2 Desencolar ");
                Console.WriteLine("3 Mostrar cola");
                Console.WriteLine("4.Mostrar primer elemento");
                Console.WriteLine("5.Mostrar tamaño de la cola");
                Console.WriteLine("6. Comprobar si está vacia");
                Console.WriteLine("7.Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un dato: ");
                        valor = int.Parse(Console.ReadLine());
                        cola.Encolar(valor);
                        break;
                    case 2:
                        valor = cola.Desencolar();

                        if (valor != -1)
                        {
                            Console.WriteLine("Dato eliminado: " + valor);
                        }
                        break;
                    case 3:
                        cola.Mostrar();
                        break;
                    case 4:
                        if(cola.Frente() == 0)
                        {
                            Console.WriteLine("No hay elementos.");
                        }
                        else
                        {
                            Console.WriteLine("El primer elemento es: {0}" +  cola.Frente());
                        }
                        break;
                    case 5:
                        if (cola.Tamaño() == 0)
                        {
                            Console.WriteLine("No hay elementos.");
                        }
                        else
                        {
                            Console.WriteLine("El tamaño de la cola es: {0}" + cola.Tamaño());
                        }
                        break;
                    case 6:
                        if (cola.EstaVacia())
                        {
                            Console.WriteLine("La cola está vacía");
                        }
                        else
                        {
                            Console.WriteLine("La cola tiene elementos.");
                        }
                        break;
                    case 7:
                        Console.WriteLine("SALIENDO");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion != 7);
        }
        public static void ColaLista(ColaLista cola)
        {
            int opcion = 0;
            int valor = 0;

            do
            {
                Console.WriteLine("Ingrese la operación que desea realizar: ");
                Console.WriteLine("1 Encolar ");
                Console.WriteLine("2 Desencolar ");
                Console.WriteLine("3 Mostrar cola");
                Console.WriteLine("4.Mostrar primer elemento");
                Console.WriteLine("5.Mostrar tamaño de la cola");
                Console.WriteLine("6. Comprobar si está vacia");
                Console.WriteLine("7.Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un dato: ");
                        valor = int.Parse(Console.ReadLine());
                        cola.Encolar(valor);
                        break;
                    case 2:
                        valor = cola.Desencolar();

                        if (valor != -1)
                        {
                            Console.WriteLine("Dato eliminado: " + valor);
                        }
                        break;
                    case 3:
                        cola.Mostrar();
                        break;
                    case 4:
                        if (cola.Frente() == 0)
                        {
                            Console.WriteLine("No hay elementos.");
                        }
                        else
                        {
                            Console.WriteLine("El primer elemento es: {0}" + cola.Frente());
                        }
                        break;
                    case 5:
                        if (cola.Tamaño() == 0)
                        {
                            Console.WriteLine("No hay elementos.");
                        }
                        else
                        {
                            Console.WriteLine("El tamaño de la cola es: {0}" + cola.Tamaño());
                        }
                        break;
                    case 6:
                        if (cola.EstaVacia())
                        {
                            Console.WriteLine("La cola está vacía");
                        }
                        else
                        {
                            Console.WriteLine("La cola tiene elementos.");
                        }
                        break;
                    case 7:
                        Console.WriteLine("SALIENDO");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion != 7);
        }
    }
}