using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colas
{
    public class ColaArreglo
    {
        private int[] cola;
        private int frente;
        private int final;

        public ColaArreglo()
        {
            cola = new int[10];
            frente = 0;
            final = -1;
        }

        public bool EstaVacia()
        {
            return final < frente;
        }

        public bool EstaLlena()
        {
            return final == cola.Length - 1;
        }

        public void Encolar(int valor)
        {
            if (EstaLlena())
            {
                Console.WriteLine("La cola está llena");
            }
            else
            {
                final++;
                cola[final] = valor;
                Console.WriteLine("Dato agregado");
            }
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
                int valor = cola[frente];
                frente++;
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
                Console.WriteLine("Cola con arreglo:");

                for (int i = frente; i <= final; i++)
                {
                    Console.Write(cola[i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}