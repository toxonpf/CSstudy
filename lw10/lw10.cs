namespace LW10
{
public class Program
{
public static void Main(string[] args)
{
void ex1()
{
    Console.WriteLine("\n 1. Список покупок.");

    List<string> list = new List<string>();

    list.Add("Молоко");
    list.Add("Хлеб");
    list.Add("Яйца");

    list.Sort();
    list.Reverse();

    foreach (string el in list) Console.WriteLine(el);
}
ex1();

void ex2()
{
    Console.WriteLine("\n 2. Список чисел.");

    List<int> numbers = new List<int>() { 5, 3, 8, 1, 4, 7, 2, 6, 9, 0 };

    Console.Write("Исходный список:");
    foreach (int num in numbers) Console.Write(" " + num);
    Console.WriteLine();

    Console.Write("Отсортированный список:");
    numbers.Sort();
    foreach (int num in numbers) Console.Write(" " + num);
    Console.WriteLine();

    Console.WriteLine($"Максимальное значение: {numbers.Max()}");
    Console.WriteLine($"Минимальное значение: {numbers.Min()}");

    Console.WriteLine($"Сумма значений: {numbers.Sum()}");

    Console.Write("Элементы больше среднего значения:");
    double average = numbers.Average();
    foreach (int num in numbers) if (num > average) Console.Write(" " + num);
    Console.WriteLine();
}
ex2();

void ex3()
{
    Console.WriteLine("\n 3. Телефонная книга. ");

    Dictionary<string, string> phones = new Dictionary<string, string>()
    {
        { "Иванов", "123-456" },
        { "Петров", "987-654" },
        { "Сидоров", "555-555" },
        { "Кузнецов", "333-444" },
        { "Смирнов", "222-333" }
    };
    Console.WriteLine("Иванов: " + phones["Иванов"]);
    phones["Иванов"] = "111-222";
    Console.WriteLine("Иванов (обновленный): " + phones["Иванов"]);
}
ex3();

void ex4()
{
    Console.WriteLine("\n 4. Пересечение двух множеств.");

    HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4, 5 };
    HashSet<int> setB = new HashSet<int>() { 4, 5, 6, 7, 8 };

    foreach (int el1 in setA.Intersect(setB))
    {
        foreach (int el2 in setB)
        {
            if (el1 == el2) Console.WriteLine("Общий элемент: " + el1);
        }
    }
}
ex4();
}
}
}