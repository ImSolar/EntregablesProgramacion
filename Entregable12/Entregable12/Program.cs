using System;

namespace Entregable12
{
    class Program
    {
        static void Main(string[] args)
        {
            PelotaBaloncesto p1 = new PelotaBaloncesto(56.5f, 6.0f);
            PelotaGolf p2 = new PelotaGolf(234.0f, 6.1f);
            PelotaBaloncesto p3 = new PelotaBaloncesto(433.34f, 5.9f);
            PelotaGolf p4 = new PelotaGolf(34.3f, 3.0f);
            Pelota[] myArray = { p1, p2, p3, p4 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(", " + myArray[i].Radio);
            }

            Metodos.OrdenarSel(myArray);

            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(", " + myArray[i].Radio);
            }
            Console.ReadLine();

        }
    }
}
