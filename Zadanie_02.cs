using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace sortowanie
{
    internal class zadanie2
    {
        static void Main()
        {
            int[] array = GenerateRandomArray(10);
            int maxValue =  FindMaxValueOfArray(array);
            Console.WriteLine(maxValue);
            Console.ReadKey();
    
        }


        public static int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100);
                Console.WriteLine(array[i]);    
            }

            return array;
        }

        public static void BubbleSort(int[] array)
        {
            int arrayLength = array.Length;
            bool swapped;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < arrayLength - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

    }
}