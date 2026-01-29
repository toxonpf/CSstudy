namespace lw8
{
    public class Class1
    {
        static void ex1(int a, int b, int c)
        {
            Console.WriteLine("\n 1. возвращает минимальное и максимальное значения: ");

            int min = Math.Min(a, Math.Min(b, c));
            int max = Math.Max(a, Math.Max(b, c));

            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Максимальное значение: {max}");
        }

        static void ex2(float[] arr)
        {
            Console.WriteLine("\n 2. возвращает массив квадратов чисел: ");

            for (int i = 0; i < arr.Length; i++) arr[i] = arr[i] * arr[i];

            Console.WriteLine("Массив квадратов чисел:");
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
        }

        static void ex3(int a, int b)
        {
            Console.WriteLine("\n 3. возвращает их наибольший общий делитель: ");

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            Console.WriteLine($"Наибольший общий делитель: {a}");
        }

        static void ex4(int n)
        {
            Console.WriteLine("\n 4. Напишите функцию FibCycle: ");

            int a = 0, b = 1, c;
            Console.Write("Fibonacci sequence: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }

        }

        static void ex5(float a, float b, float c)
        {
            Console.WriteLine("\n 5. Напишите функцию для вычисления корней квадратного уравнения: ");
            float discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                float root1 = (-b + (float)Math.Sqrt(discriminant)) / (2 * a);
                float root2 = (-b - (float)Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Два корня: {root1} и {root2}");
            }
            else if (discriminant == 0)
            {
                float root = -b / (2 * a);
                Console.WriteLine($"Один корень: {root}");
            }
            else
            {
                Console.WriteLine("Корней нет.");
            }
        }

        static void Main(string[] args)
        {
            ex1(5, 10, 15);
            ex2(new float[] { 1.0f, 2.0f, 3.0f });
            ex3(12, 18);
            ex4(10);
            ex5(1.0f, -3.0f, 2.0f);
        }
    }
}

