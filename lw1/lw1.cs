using System;

namespace test
{
    class lw1
    {
        static void ex1()
        {
            Console.WriteLine("\n Задание 4. Создать консольное приложение, которое выводит на экран следующую информацию:");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("название страны: Казахстан");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("название города: Алматы");

            Console.ResetColor();
            Console.WriteLine("текущий год: 2026");
        }

        static void ex2()
        {
            Console.WriteLine("\n Задание 5. Запросить у пользователя его имя и возраст.");
            Console.Write("Введите ваше имя: ");
            string? name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            string? age = Console.ReadLine();

            Console.WriteLine($"Привет, {name}! Вам {age} лет.");
        }

        static void Main(string[] args)
        {
            ex1();
            ex2();
        }
    }
};