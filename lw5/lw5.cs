
namespace lw5
{
    internal class lw5
    {
        static void ex1()
        {
            Console.WriteLine("\n 1. Запрашивает у пользователя число N и вычисляет сумму всех чисел от 1 до N включительно.");

            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Сумма чисел от 1 до {n} равна {sum}");
        }

        static void ex2()
        {
            Console.WriteLine("\n 2. выводит все символы от начального до конечного включительно.");

            Console.Write("Введите начальный символ: ");
            char startChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите конечный символ: ");
            char endChar = Convert.ToChar(Console.ReadLine());

            for (char c = startChar; c <= endChar; c++)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        static void ex3()
        {
            Console.WriteLine("\n 3. запрашивает у пользователя числа до тех пор, пока не будет введено отрицательное число.");

            int number;
            int sum = 0;
            do
            {
                Console.Write("Введите число (отрицательное число для выхода): ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                {
                    sum += number;
                }
            } while (number >= 0);

            Console.WriteLine($"Сумма введенных неотрицательных чисел равна {sum}");
        }

        static void ex4()
        {
            Console.WriteLine("\n 4. Вычисляет количество цифр в этом числе");

            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (number > 0)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine($"Количество цифр в числе: {count}");
        }

        static void ex5()
        {
            Console.WriteLine("\n 5. Генерирует случайное число от 1 до 100 и просит пользователя угадать это число.");

            Random rand = new Random();
            int targetNumber = rand.Next(1, 101);
            int guess;

            do
            {
                Console.Write("Угадайте число от 1 до 100: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < targetNumber)
                {
                    Console.WriteLine("Слишком мало!");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Слишком много!");
                }
                else
                {
                    Console.WriteLine("Поздравляем! Вы угадали число!");
                }
            } while (guess != targetNumber);
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