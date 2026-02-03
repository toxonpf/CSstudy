namespace lw2
{
    internal class lw2
    {
        static void ex1()
        {
            Console.WriteLine("\n 1. Объявление и инициализация переменных.");
            int a = 5;
            double b = 4.5;
            char c = 'A';
            string d = "Hello";
            bool e = true;
            
            Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}, e: {e}");
        }

        static void ex2()
        {
            Console.WriteLine("\n 2. Использование неявной типизации.");
            byte a = 255;
            short b = 32767;

            int sum = a + b;
            Console.WriteLine($"type: {sum.GetType()}, sum: {sum}");
        }

        static void ex3()
        {
            Console.WriteLine("\n 3. Константы и вычисления");
            const double pi = 3.1415;
            int r = 5;
            const double G = 9.81;

            Console.WriteLine($"S = {pi * (r * r)}");
        }

        static void ex4()
        {
            Console.WriteLine("\n 4. Явное и неявное преобразование.");
            double a = 15.75;
            int b = (int)a;
            Console.WriteLine($"a: {a}, b: {b}");
        }

        static void ex5()
        {
            Console.WriteLine("\n 5. Литералы в разных системах счисления.");
            int a = 42;
            int b = 0x2A;
            int c = 0b101010;

            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }

        static void ex6()
        {
            Console.WriteLine("\n 6. Экранирование и строки.");
            string adress = @"C:\Users\Public\Documents\data.txt.";
            string adressУ = "C:\\Users\\Public\\Documents\\data.txt.";

            Console.WriteLine(adress + "\n" + adressУ);
        }
        private static void Main(string[] args)
        {
            ex1();
            ex2();
            ex3();
            ex4();
            ex5();
            ex6();
        }
    }
}