namespace lw7
{
    internal class lw7
    {
        static void ex1()
        {
            Console.WriteLine("\n 1. матрица 3х5, заполненная случайными числами от -10 до 10:");

            int[,] arr = new int[3, 5];
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-10, 11);
                    Console.Write($"{arr[i, j],6}");
                }
                Console.WriteLine();
            }
        }

        static void ex2()
        {
            Console.WriteLine("\n 2. Матрица 3х5, заполненная случайными числами от 10 до 99:");

            short[,] arr = new short[3, 5];
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = Convert.ToInt16(rand.Next(10, 100));
                    Console.Write($"{arr[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n суммы элементов строк:");
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine($" сумма строки {i}: {sum}");
                sum = 0;
            }
        }

        static void ex3()
        {
            Console.WriteLine("\n 3. Найти минимальный и максимальный элемент в каждом столбце.");

            char[,] chars = new char[4, 2];
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    Console.Write($"введите символ для элемента [{i}, {j}]: ");
                    chars[i, j] = Convert.ToChar(Console.ReadLine());
                }
            }

            Console.WriteLine("Введеная матрица: ");
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    Console.Write($"{chars[i, j],4}");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < chars.GetLength(1); i++)
            {
                char max = chars[i, 0];
                char min = chars[i, 0];
                for (int j = 0; j < chars.GetLength(0); j++)
                {
                    if (max < chars[j, i]) max = chars[j, i];
                    if (min > chars[j, i]) min = chars[j, i];
                }
                Console.WriteLine($"Сторлбец {i}: min = {min}, max = {max}");
                max = chars[i, 0];
                min = chars[i, 0];
            }
        }

        static void ex4()
        {
            Console.WriteLine("\n 4. программа должна заменить все отрицательные элементы массива на их квадраты");

            Console.Write("Количество строк: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] arr = new double[m, n];
            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-5, 6);
                }
            }

            Console.WriteLine("исходный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("обновленный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0) arr[i, j] = Math.Pow(arr[i, j], 2);
                    Console.Write($"{arr[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            ex1();
            ex2();
            ex3();
            ex4();
        }
    }
}