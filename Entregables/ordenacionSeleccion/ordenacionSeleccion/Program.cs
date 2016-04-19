using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenacionSeleccion
{
    class Program
    {
        public static int[] miArray = { 23, 3, 6, 36, 7, 5 };
        static void Main(string[] args)
        {
            OrdenacionPorSeleccion(miArray);
            ImprimeArray(miArray);
            Console.ReadKey();

        }

        public static void ImprimeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }

        public static void OrdenacionPorSeleccion(int[] array)
        { 
            // for de fuera que nos da el array
            for (int i = 0; i < array.Length; i++)
            {
                int posicionMinima = i;

                    for (int j = 0; j < array.Length; j++)
                        {
                            if (array[posicionMinima] > array[j])
                                posicionMinima = j;                 
                        }

                        if(posicionMinima != i)
                        {
                            int aux = array[i];
                            array[i] = array[posicionMinima];
                            array[posicionMinima] = aux;
                        }
             }
        }
    }
}