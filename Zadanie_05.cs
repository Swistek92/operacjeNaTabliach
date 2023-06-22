using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace sortowanie
{
    internal class zadanie3
    {
        static void Main()
        {
            int[] array = GenerateRandomArray(10);
            int[] sortedNumbers = SelectionSort(array);

            Console.WriteLine("Posortowana tablica:");
            foreach (int number in sortedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadKey();  

        }


        public static int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100);
              
            }

            return array;
        }

        public static int[] SelectionSort(int[] array)
        {
            int n = array.Length;
            int[] sortedArray = new int[n];
            Array.Copy(array, sortedArray, n);

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (sortedArray[j] < sortedArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = sortedArray[i];
                sortedArray[i] = sortedArray[minIndex];
                sortedArray[minIndex] = temp;
            }

            return sortedArray;
        }

    }
}