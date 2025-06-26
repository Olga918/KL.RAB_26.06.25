using System.Runtime.Serialization;
using System.Text;

namespace KL.RAB_26._06._25
{

    public class Program
    {
        //public delegate bool FilterDelegate(int number);

        //public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        //{
        //    Random rand = new Random();
        //    int[] array = new int[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        array[i] = rand.Next(minValue, maxValue + 1);
        //    }
        //    return array;
        //}

        //public static int[] FilterArray(int[] array, FilterDelegate filter)
        //{

        //    int count = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (filter.Invoke(array[i]))
        //        {
        //            count++;
        //        }
        //    }


        //    int[] result = new int[count];
        //    int index = 0;


        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (filter.Invoke(array[i]))
        //        {
        //            result[index++] = array[i];
        //        }
        //    }

        //    return result;
        //}

        //public static bool IsMultipleOfThree(int number)
        //{
        //    return number % 3 == 0;
        //}

        //public static bool IsNegative(int number)
        //{
        //    return number < 0;
        //}

        //public static void Main()
        //{
        //    int[] randomArray = GenerateRandomArray(20, -10, 20);

        //    Console.WriteLine("Original array:");
        //    Console.WriteLine(string.Join(", ", randomArray));

        //    int[] multiplesOfThree = FilterArray(randomArray, IsMultipleOfThree);
        //    Console.WriteLine("\nMultiple 3:");
        //    Console.WriteLine(string.Join(", ", multiplesOfThree));

        //    int[] negatives = FilterArray(randomArray, IsNegative);
        //    Console.WriteLine("\nNegative numbers:");
        //    Console.WriteLine(string.Join(", ", negatives));
        //}
        /// <summary>
        /// /////////////////////////////////////////////////

        // public delegate bool FilterDelegate(int number);

        // // Генерация случайного массива
        // public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        // {
        //     Random rnd = new Random();
        //     int[] arr = new int[size];
        //     for (int i = 0; i < size; i++)
        //         arr[i] = rnd.Next(minValue, maxValue + 1);
        //     return arr;
        // }

        // // Метод расширения массива, добавление одного элемента
        // public static int[] AddElement(int[] array, int element)
        // {
        //     int[] newArray = new int[array.Length + 1];
        //     for (int i = 0; i < array.Length; i++)
        //         newArray[i] = array[i];
        //     newArray[array.Length] = element;
        //     return newArray;
        // }


        //static int[] FilterArray(int[] array, FilterDelegate filter)
        // {
        //     int[] y = []; // Инициализация пустого массива для хранения результатов
        //     foreach (int number in array)
        //     {
        //         if(filter(number)) // Проверка условия фильтрации
        //         {
        //             y = AddElement(y, number); // Добавление элемента в массив результатов
        //         }
        //     }
        //     return y;
        // }
        // // Фильтр для проверки на кратность 3
        // public static bool IsMultipleOfThree(int number)
        // {
        //     return number % 3 == 0;
        // }
        // // Фильтр для проверки на отрицательные числа
        // public static bool IsNegative(int number)
        // {
        //     return number < 0;
        // }
        // public static void Main()
        // {
        //     int[] randomArray = GenerateRandomArray(20, -10, 20);
        //     Console.WriteLine("Original array:");
        //     Console.WriteLine(string.Join(", ", randomArray));
        //     int[] multiplesOfThree = FilterArray(randomArray, IsMultipleOfThree);
        //     Console.WriteLine("\nMultiple of 3:");
        //     Console.WriteLine(string.Join(", ", multiplesOfThree));
        //     int[] negatives = FilterArray(randomArray, IsNegative);
        //     Console.WriteLine("\nNegative numbers:");
        //     Console.WriteLine(string.Join(", ", negatives));
        // }

        /////////////////////////////////////////////

        public delegate bool FilterDelegate(int number);

        // Генерация случайного массива
        public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(minValue, maxValue + 1);
            return arr;
        }

        // Метод расширения массива, добавление одного элемента
        public static int[] AddElement(int[] array, int element)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i];
            newArray[array.Length] = element;
            return newArray;
        }

        static int[] FilterArray(int[] array, FilterDelegate filter)
        {
            int[] y = new int[0]; // Пустой массив для результата
            foreach (int number in array)
            {
                if (filter(number)) // Проверка условия
                {
                    y = AddElement(y, number); // Добавление элемента
                }
            }
            return y;
        }

        // Фильтр на кратность 3
        public static bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0;
        }

        // Фильтр на отрицательные числа
        public static bool IsNegative(int number)
        {
            return number < 0;
        }

        public static void Main()
        {
            int[] randomArray = GenerateRandomArray(20, -10, 20);

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", randomArray));

            // Вызов через обычные методы
            int[] multiplesOfThree = FilterArray(randomArray, IsMultipleOfThree);
            Console.WriteLine("\nMultiples of 3 (method):");
            Console.WriteLine(string.Join(", ", multiplesOfThree));

            int[] negatives = FilterArray(randomArray, IsNegative);
            Console.WriteLine("\nNegative numbers (method):");
            Console.WriteLine(string.Join(", ", negatives));

            // Вызов через лямбда-выражения
            int[] lambdaMultiples = FilterArray(randomArray, n => n % 3 == 0);
            Console.WriteLine("\nMultiples of 3 (lambda):");
            Console.WriteLine(string.Join(", ", lambdaMultiples));

            int[] lambdaNegatives = FilterArray(randomArray, n => n < 0);
            Console.WriteLine("\nNegative numbers (lambda):");
            Console.WriteLine(string.Join(", ", lambdaNegatives));
        }
    }
}

