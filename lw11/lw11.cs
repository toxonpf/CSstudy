

namespace lw11
{
    public class lw11
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\toxon\source\repos\toxonpf\CSstudy\lw11\toxonpf.txt";
            void ex1()
            {
                Console.WriteLine("\n 1. Создание каталога.");

                if (!File.Exists(fileName)) File.Create(fileName).Close();
                else Console.WriteLine($"File already exists:");
            }
            ex1();

            void ex2()
            {
                Console.WriteLine("\n 2. Создание списка задач");

                if (File.Exists(fileName)) {
                    while (true)
                    {
                        Console.Write("Введите задачу:");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "exit") break;
                        File.AppendAllText(fileName, input + Environment.NewLine);
                    }
                }   
                else Console.WriteLine("File does not exist");
            }
            ex2();
        }
    }
}