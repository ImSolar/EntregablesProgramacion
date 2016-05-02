namespace binarySearch
{
    class Program
    {
        public static int[] myArray = { 1,2,4,5,6,7 };
        static void Main(string[] args)
        {
            System.Console.WriteLine(BinarySearchRecursive(myArray, 7, 0, myArray.Length-1));
            System.Console.ReadKey();
        }




        public static int BinarySearchRecursive(int[] array, int numero, int minIntervalo, int maxIntervalo)
        {


            if ((maxIntervalo - minIntervalo) / 2 == 0)
            {
                if (array[minIntervalo + 1] == numero)
                    return minIntervalo + 1;
                else
                    return -1;
            }

            else
            {
                int indice = (maxIntervalo - minIntervalo) / 2 + minIntervalo;
                if (array[indice] == numero)
                {
                    return indice;
                }
                else
                {
                    if (array[indice] > numero)
                    {
                        return BinarySearchRecursive(array, numero, minIntervalo, indice);
                    }
                    else if (array[indice] == numero)
                    {
                        return indice;
                    }
                    else
                    {
                        return BinarySearchRecursive(array, numero, indice, maxIntervalo);
                    }
                }
            }
        }











    }
}
