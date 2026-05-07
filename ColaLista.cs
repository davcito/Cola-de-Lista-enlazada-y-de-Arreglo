using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colas
{
    public class ColaLista
    {
        private Nodo primero;
        private Nodo ultimo;
        private int cont = 0;

        public ColaLista()
        {
            primero = null;
            ultimo = null;
        }

        public bool EstaVacia()
        {
            return primero == null;
        }

        public void Encolar(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (EstaVacia())
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            cont++;
            Console.WriteLine("Dato agregado");
        }

        public int Desencolar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La cola está vacía");
                return -1;
            }
            else
            {
                int valor = primero.dato;
                primero = primero.siguiente;

                if (primero == null)
                {
                    ultimo = null;
                }
                cont--;
                return valor;
            }
        }

        public void Mostrar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La cola está vacía");
            }
            else
            {
                Nodo actual = primero;

                Console.WriteLine("Cola con lista enlazada:");

                while (actual != null)
                {
                    Console.Write(actual.dato + " ");
                    actual = actual.siguiente;
                }

                Console.WriteLine();
            }
        }
        public int Frente()
        {
            if (EstaVacia())
            {
                return -1;
            }
            else
            {
                return primero.dato;
            }
        }

        public int Tamaño()
        {
            return cont;
        }
    }
}
