using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable_7___Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static char[] InvertirVector(char[] vector, int indice)
        {
            if (indice >= vector.Length/2)
            {
                if (vector.Length % 2 != 0) return new char[] { vector[indice] };
                else return new char[] { vector[vector.Length - (indice + 1)], vector[indice] };
            }
            else
            {
                char[] vectorInvertido = new char[vector.Length - (indice * 2)];
                vectorInvertido[0] = vector[vector.Length - (indice + 1)];
                vectorInvertido[vectorInvertido.Length] = vector[indice];
                char[] aux = InvertirVector(vector, indice + 1);

                for (int i = 1, j= 0; j < aux.Length; i++,j++)
                {
                    vectorInvertido[i] = aux[j];
                }

                return vectorInvertido;
            }
        }
    }
}
