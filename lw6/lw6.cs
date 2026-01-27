namespace lw6
{
    internal class lw6
    {
        static void ex1()
        {
            Console.WriteLine("\n 1. Объявите массив целых чисел (byte) и найдите максимальный элемент");

            byte[] arr = { 1, 2, 3, 4, 5 };
            double[] arr2 = { 4.1, 5, 6.55, 7 };
            string[] arr3 = { "rick", "shtik", "estley" };

            Console.WriteLine($"максимальный элемент: {arr.Max()}");

            double sum = 0;
            for (int i = 0; i < arr2.Length; i++) sum += arr2[i];
            Console.WriteLine($"сумма элементов: {sum}");

            for (int i = 0; i < arr3.Length; i++) Console.WriteLine(arr3[i]);
        }

        static void ex2()
        {
            Console.WriteLine("\n 2. сортирует массив по возрастанию и выводит отсортированный массив.");

            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
            string arrStr = string.Join(" ", arr);
            Console.WriteLine($"отсортированный массив: {arrStr}");
        }

        static void ex3()
        {
            Console.WriteLine("\n 3. Поиск элементов, больше среднего.");

            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            double middle = (double)sum / size;
            Console.Write("Элементы больше среднего значения: ");
            string letter = "";
            foreach (int num in arr) if (num > middle) letter += num + " ";
            Console.WriteLine(letter);
        }

        static void ex4()
        {
            Console.WriteLine("\n 4. Подсчет количества положительных и отрицательных элементов.");

            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int pl = 0;
            int mn = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] > 0) pl++;
                else if (arr[i] < 0) mn++;
            }

            Console.WriteLine($"Положительных элементов: {pl}");
            Console.WriteLine($"Отрицательных элементов: {mn}");
        }

        static void ex5()
        {
            Console.WriteLine("\n 5. Сумма элементов массива с четными индексами.");

            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0) sum += arr[i];
            }
            Console.WriteLine($"Сумма элементов массива с четными индексами: {sum}");
        }

        static void Main(string[] args)
        {
            ex1();
            ex2();
            ex3();
            ex4();
            ex5();
        }
    }
}
