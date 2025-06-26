namespace KL.RAB_26._06._25
{

    public class Program
    {
        public delegate bool FilterDelegate(int number);

        public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(minValue, maxValue + 1);
            }
            return array;
        }

        public static int[] FilterArray(int[] array, FilterDelegate filter)
        {

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (filter.Invoke(array[i]))
                {
                    count++;
                }
            }


            int[] result = new int[count];
            int index = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (filter.Invoke(array[i]))
                {
                    result[index++] = array[i];
                }
            }

            return result;
        }

        public static bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0;
        }

        public static bool IsNegative(int number)
        {
            return number < 0;
        }

        public static void Main()
        {
            int[] randomArray = GenerateRandomArray(20, -10, 20);

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", randomArray));

            int[] multiplesOfThree = FilterArray(randomArray, IsMultipleOfThree);
            Console.WriteLine("\nMultiple 3:");
            Console.WriteLine(string.Join(", ", multiplesOfThree));

            int[] negatives = FilterArray(randomArray, IsNegative);
            Console.WriteLine("\nNegative numbers:");
            Console.WriteLine(string.Join(", ", negatives));
        }
    }
}