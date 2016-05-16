using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable12
{
    class Metodos
    {
        public static void OrdenarSel(Pelota[] array)
        {
            int minimo;
            Pelota aux;

            for (int i = 0; i < array.Length - 1; i++)
            {
                minimo = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minimo]) == -1)
                    {
                        minimo = j;
                    }
                }
                aux = array[i];
                array[i] = array[minimo];
                array[minimo] = aux;
            }
        }
    }
}
