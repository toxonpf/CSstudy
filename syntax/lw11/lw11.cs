namespace lw11
{
    public class lw11
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\prl\codes\cs\CSstudy\lw11\toxonpf.txt";
            void ex1()
            {
                Console.WriteLine("\n 1. Создание каталога.");

                if (!File.Exists(fileName)) File.Create(fileName).Close();
                else Console.WriteLine($"File already exists:");
            }

            void ex2()
            {
                Console.WriteLine("\n 2. Создание списка задач");

                if (File.Exists(fileName)) return;

                while (true)
                {
                    Console.Write("Введите задачу:");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "exit") break;
                    File.AppendAllText(fileName, input + Environment.NewLine);
                }
            }

            void ex3()
            {
                Console.WriteLine("\n 3. Чтение и отображение списка задач");

                if (File.Exists(fileName)) return;

                string[] tasks = File.ReadAllLines(fileName);
                Console.WriteLine("Список задач:");
                foreach (string task in tasks) Console.WriteLine("- " + task);
            }

            void ex4()
            {
                Console.WriteLine("\n 4. поиск задачи по ключевому слову");

                if (!File.Exists(fileName)) return;

                Console.Write("введите ключевое слово для поиска задачи: ");
                string keyword = Console.ReadLine();
                string[] tasks = File.ReadAllLines(fileName);
                foreach (string task in tasks)
                {
                    if (task.Contains(keyword))
                    {
                        Console.WriteLine("найдена задача: " + task);
                    }
                }
            }

            void ex5()
            {
                Console.WriteLine("\n 5. Сортировка задач по алфавиту.");

                if (!File.Exists(fileName)) return;

                string[] tasks = File.ReadAllLines(fileName);
                Array.Sort(tasks);

                File.WriteAllLines(fileName, tasks);

                Console.WriteLine("Задачи отсортированы по алфавиту:");
                foreach (string task in tasks) Console.WriteLine("- " + task);
            }

            void running()
            {
                ex1();
                ex2();
                ex3();
                ex4();
                ex5();
            }
            running();
        }
    }
}