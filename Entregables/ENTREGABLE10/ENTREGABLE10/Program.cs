using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTREGABLE10
{
    class Program
    {




        static void Main(string[] args)
        {


        }
        public void Ejemplo(int a, int[] x)
        {
            if (a > 0)
                for (int i = 0; i < x.Length; i++)
                    x[i]++;

            else
                for (int i = 0; i < x.Length; i++)
                    x[i] = 0;


        }
    }
}
