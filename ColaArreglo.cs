using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colas
{
    public class ColaArreglo
    {
        private int[] cola = Array.Empty<int>();
        private int frente;
        private int final;

        public ColaArreglo()
        {
            frente = 0;
            final = -1;
        }

        public bool EstaVacia()
        {
            return final < frente;
        }

        //public bool EstaLlena()
        //{
        //    return final == cola.Length - 1;
        //}

        public void Encolar(int valor)
        {        
                Array.Resize(ref cola, cola.Length + 1);
                cola[cola.Length - 1] = valor;
                final = cola.Length - 1;
                Console.WriteLine("Dato agregado");
        }

        public int Tamaño()
        {
            return cola.Length;
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
                
                for(int i = 1; i < cola.Length; i++)
                {
                    cola[i - 1] = cola[i];
                }

                Array.Resize(ref cola, cola.Length - 1);
                final = cola.Length - 1;
                return valor;
            }
        }

        public int Frente()
        {
            return cola[frente];
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

                for (int i = frente; i < cola.Length; i++)
                {
                    Console.Write(cola[i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}