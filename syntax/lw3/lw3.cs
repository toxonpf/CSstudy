namespace lw3
{
    internal class lw3
    {
        static void ex1()
        {
            Console.WriteLine("\n 1. Арифметические операции и составное присваивание");

            int x = 10;

            x += 5;
            x *= 2;
            x /= 4;

            Console.WriteLine($"x: {x}");
        }

        static void ex2()
        {
            Console.WriteLine("\n 2. Ввод данных и преобразование типов.");

            Console.WriteLine("Введите целое число 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            if (b != 0) Console.WriteLine(a / b);
            else Console.WriteLine("Деление на ноль невозможно.");
        }

        static void ex3()
        {
            Console.WriteLine("\n 3. Работа с классом Math");

            Console.WriteLine("Введите число (double): ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Квадратный корень: {Math.Sqrt(num)}");
            Console.WriteLine($"Квадратный корень: {Math.Round(num)}");
            Console.WriteLine($"Модуль числа: {Math.Abs(num)}");
            Console.WriteLine($"Возведение в степень 2: {Math.Pow(num, 2)}");
        }

        static void ex4()
        {
            Console.WriteLine("\n 4. Генерация случайных чисел.");
            
            Random rand = new Random();

            Console.WriteLine($"Случайное целое число от 1 до 100: {rand.Next(1, 101)}");
            Console.WriteLine($"Случайное число с плавающей точкой от 0.0 до 1.0: {rand.NextDouble()}");
            Console.WriteLine($"Случайное целое число от -50 до 50: {rand.Next(-50, 51)}");
        }

        static void ex5()
        {
            Console.WriteLine("\n 5. Площадь треугольника.");

            Console.Write("Введите 1 сторону треугольника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 сторону треугольника: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3 сторону треугольника: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double s = (a + b + c) / 2.0;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"Площадь треугольника: {area}");
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
