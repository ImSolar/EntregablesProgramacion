using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacionBurbuja
{
    class Program
    {
        public static int[] miArray = { 4, 7, 24, 5, 3 };
        static void Main(string[] args)
        {
            OrdenacionPorMetodoBurbuja(miArray);
            ImprimirArray(miArray);
            Console.ReadKey();
        }

        public static void OrdenacionPorMetodoBurbuja(int[] array)
        {
            bool ordenado = false;
            int contadorNumerosOrdenados = 0;
            

            while (!ordenado)
            {
                for (int i = 1; i < array.Length; i++)
                {
                   int actual = ComprobarParDeNumeros(array[i - 1], array[i]);

                    if (actual == array[i - 1])
                    {
                        contadorNumerosOrdenados = 0;
                        int aux = array[i];
                        array[i] = array[i-1];
                        array[i - 1] = aux;
                    }
                    else
                    {
                        contadorNumerosOrdenados += 1;
                    }

                    if (contadorNumerosOrdenados == array.Length)
                    {
                        ordenado = true;
                        break;
                    }
                                            
                }
            }
        }
        /// <summary>
        /// Compara dos numeros y devuelve el mayor de ambos
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int ComprobarParDeNumeros(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }

        public static void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }

    }
}
