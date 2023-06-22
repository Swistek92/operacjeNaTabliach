namespace sortowanie1
{
    internal class zadanie1
    {
        static void Main()
        {
            int[] array = GenerateRandomArray(10);
            PrintArrayReverse(array);
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

        public static void PrintArrayReverse(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}