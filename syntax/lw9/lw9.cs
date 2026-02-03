namespace lw9
{
internal class lw9
{


static void Main(string[] args)
{
int ex1(string str) => str.Length;
Console.WriteLine("\n 1. Подсчет символов в строке.");
Console.WriteLine(ex1("hello world"));

string ex2(string str)
{
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}
Console.WriteLine("\n 2. Реверс строки.");
Console.WriteLine(ex2("hello world"));

string ex3(string str) => str.Replace(" ", "*");
Console.WriteLine("\n 3. Замена пробелов на звездочки.");
Console.WriteLine(ex3("hello world"));

bool ex4(string str)
{
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    if (new string(arr) == str) return true;
    else return false;
}
Console.WriteLine("\n 4. Проверка на палиндром.");
Console.WriteLine(ex4("шалаш"));

bool ex5()
{
    Console.WriteLine("\n 5. Проверка надежности пароля.");
    Console.Write("Введите пароль: ");
    string password = Console.ReadLine();
    if (
        password.Length > 8 &&
        password.Any(char.IsUpper) &&
        password.Any(char.IsLower) &&
        password.Any(char.IsDigit)
    ) return true;
    else return false;
}
Console.WriteLine(ex5());
}
}
}