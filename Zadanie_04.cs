using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace sortowanie
{
    internal class zadanie3
    {
        static void Main()
        {
            int[] array = GenerateRandomArray(10);
            int[] sortedNumbers = InsertionSort(array);

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

        public static int[] InsertionSort(int[] array)
        {
            int n = array.Length;
            int[] sortedArray = new int[n];
            Array.Copy(array, sortedArray, n);

            for (int i = 1; i < n; i++)
            {
                int key = sortedArray[i];
                int j = i - 1;

                while (j >= 0 && sortedArray[j] > key)
                {
                    sortedArray[j + 1] = sortedArray[j];
                    j--;
                }

                sortedArray[j + 1] = key;
            }

            return sortedArray;
        }



    }
}