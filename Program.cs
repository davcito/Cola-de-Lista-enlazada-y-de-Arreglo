using System;
using Colas;


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
                Console.WriteLine("1 Encolar en arreglo");
                Console.WriteLine("2 Desencolar en arreglo");
                Console.WriteLine("3 Mostrar arreglo");
                Console.WriteLine("4 Encolar en lista enlazada");
                Console.WriteLine("5 Desencolar en lista enlazada");
                Console.WriteLine("6 Mostrar lista enlazada");
                Console.WriteLine("7 Salir");
           
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese dato: ");
                        valor = int.Parse(Console.ReadLine());
                        colaArreglo.Encolar(valor);
                        break;

                    case 2:
                        valor = colaArreglo.Desencolar();

                        if (valor != -1)
                        {
                            Console.WriteLine("Dato eliminado: " + valor);
                        }
                        break;

                    case 3:
                        colaArreglo.Mostrar();
                        break;

                    case 4:
                        Console.Write("Ingrese dato: ");
                        valor = int.Parse(Console.ReadLine());
                        colaLista.Encolar(valor);
                        break;

                    case 5:
                        valor = colaLista.Desencolar();

                        if (valor != -1)
                        {
                            Console.WriteLine("Dato eliminado: " + valor);
                        }
                        break;

                    case 6:
                        colaLista.Mostrar();
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