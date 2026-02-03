namespace lw12
{
public class lw12
{
static void ex1()
{
    Console.WriteLine("\n 1. Обработка исключений при работе с файлами. ");

    string fileLocation = @"D:\prl\codes\cs\CSstudy\lw12\toxonpf.txt";
    List<int> allNums = new List<int>();
    try
    {
        if (!File.Exists(fileLocation)) throw new FileNotFoundException("файл не найден");

        string[] lines = File.ReadAllLines(fileLocation);

        foreach (string line in lines)
        {
            int[] nums = line.Split(", ").Select(int.Parse).ToArray();
            allNums.AddRange(nums);
        }

        Console.WriteLine($"Среднее число: {allNums.Average()}");
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
    }
    catch (UnauthorizedAccessException ex)
    {
        Console.WriteLine($"Ошибка доступа к файлу: {ex.Message}");
    }
    
    catch (Exception ex)
    {
        Console.WriteLine($"Произошла ошибка: {ex.Message}");
    }

    string resultAdress = @"D:\prl\codes\cs\CSstudy\lw12\result.txt";
    try
    {
        using (StreamWriter writer = new StreamWriter(resultAdress, false))
        {
            writer.WriteLine($"Среднее число: {allNums.Average()}");
        }
        Console.WriteLine("Результат записан в файл result.txt");
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
    }
    catch (UnauthorizedAccessException ex)
    {
        Console.WriteLine($"Ошибка доступа к файлу: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошла ошибка: {ex.Message}");
    }
}

static void ex2()
{
    Console.WriteLine("\n 2. Обработка исключений в калькуляторе.");

    Console.Write("Введите первое число: ");
    int input1;
    while (true)
    {
        try
        {
            input1 = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message} Повторите ввод:");
        }
    }
    Console.Write("Введите второе число: ");
    int input2;
    while (true)
    {
        try
        {
            input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 == 0)
            {
                Console.Write("Деление на ноль невозможно. Попробуйте снова:");
                continue;
            }
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message} Повторите ввод:");
        }
    }

    Console.Write("Введите операцию (+, -, *, /): ");
    string operation;
    while (true)
    {
        try
        {
            operation = Console.ReadLine();
            if (
                operation != "+" && 
                operation != "-" && 
                operation != "*" && 
                operation != "/"
            )
            {
                Console.Write("Недопустимая операция. Попробуйте снова:");
                continue;
            }
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message} Повторите ввод:");
        }
    }

    try
    {
        double result = operation switch
        {
            "+" => input1 + input2,
            "-" => input1 - input2,
            "*" => input1 * input2,
            "/" => (double)input1 / input2,
            _ => throw new InvalidOperationException("Недопустимая операция.")
        };
        Console.WriteLine($"Результат: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошла ошибка при вычислении: {ex.Message}");
    }
}

public static void Main(string[] args)
{
    ex1();
    ex2();
}
}
}