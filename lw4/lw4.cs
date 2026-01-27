namespace lw4
{
    internal class lw4
    {
        static void ex1()
        {
            Console.WriteLine("\n 1. Даны три целых числа. Определите, сколько среди них совпадающих.");

            Console.WriteLine("Введите целое число 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine(3);
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        static void ex2()
        {
            Console.WriteLine("\n 2. Принимает число и проверяет, является ли оно одновременно четным и положительным.");

            Console.WriteLine("Введите целое число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num % 2 == 0)
            {
                Console.WriteLine("Число является одновременно четным и положительным.");
            }
            else if (num > 0 && num % 2 != 0)
            {
                Console.WriteLine("Число положительное, но нечетное.");
            }
            else if (num < 0 && num % 2 == 0)
            {
                Console.WriteLine("Число четное, но отрицательное.");
            }
            else
            {
                Console.WriteLine("Число является одновременно отрицательным и нечетным.");
            }
        }

        static void ex3()
        {
            Console.WriteLine("\n 3. Шахматная ладья");

            Console.WriteLine("Введите координату X1 (1-8): ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y1 (1-8): ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату X2 (1-8): ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y2 (1-8): ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            if (x1 == x2 || y1 == y2)
            {
                Console.WriteLine("Ладья может переместиться на эту позицию за один ход.");
            }
            else
            {
                Console.WriteLine("Ладья не может переместиться на эту позицию за один ход.");
            }
        }

        static void ex4()
        {
            Console.WriteLine("\n 4. Шахматный ферзь");

            Console.WriteLine("Введите координату X1 (1-8): ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y1 (1-8): ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату X2 (1-8): ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y2 (1-8): ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            if (x1 == x2 || y1 == y2 || Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
            {
                Console.WriteLine("Ферзь может переместиться на эту позицию за один ход.");
            }
            else
            {
                Console.WriteLine("Ферзь не может переместиться на эту позицию за один ход.");
            }
        }

        static void ex5()
        {
            Console.WriteLine("\n 5. Создайте программу-калькулятор");

            Console.WriteLine("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операцию (+, -, *, /): ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Результат: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка: Неверная операция.");
                    break;
            }
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