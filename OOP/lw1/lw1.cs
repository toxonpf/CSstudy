namespace lw1
{
public class User
{
    private string Username { get; set; }
    private string Email { get; set; }

    public User(string username, string email)
    {
        Username = username;
        Email = email;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"Username: {Username}, Email: {Email}");
    }
}

public class Car
{
    private string Model { get; set; }
    private string Year { get; set; }
    private string Color { get; set; }
    private int _speed;
    public int Speed
    {
        get { return _speed; }
        set { _speed = value < 0 ? 0 : value; }
    }

    public Car(string model, string year, string color, int speed)
    {
        Model = model;
        Year = year;
        Color = color;
        Speed = speed < 0 ? 0 : speed;
    }

    public void StartEngine()
    {
        System.Console.WriteLine("Двигатель заведен");
    }

    public void Accelerate(int speed)
    {
        Speed = speed < 0 ? 0 : speed;
    }
}

public class Cat
{
    private string Name { get; set; }
    private int Age { get; set; }
    private string Color { get; set; }

    public Cat(string name, int age, string color)
    {
        Name = name;
        Age = age;
        Color = color;
    }

    public void Meow()
    {
        System.Console.WriteLine("мяу!");
    }

    public void Eat()
    {
        System.Console.WriteLine("Мурлыкаю");
    }
}

public class book
{
    private string Title { get; set; }
    private string Author { get; set; }
    private int YearPublished { get; set; }
    private int NumberOfPages { get; set; }

    // Конструктор: название и автор
    public book(string title, string author, int numberOfPages)
    {
        Title = title;
        Author = author;
        NumberOfPages = numberOfPages;
    }

    public book(string title, string author, int yearPublished, int numberOfPages)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
        NumberOfPages = numberOfPages;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"Title: {Title}, Author: {Author}, Year Published: {YearPublished}, Number of Pages: {NumberOfPages}");
    }
}

public class lw1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n class User");
        User user = new User("john_doe", "john@example.com");
        user.DisplayInfo();

        Console.WriteLine("\n class Car");
        Car car = new Car("Toyota", "2020", "Red", 50);
        car.StartEngine();
        car.Accelerate(80);
        Console.WriteLine($"Car speed: {car.Speed} km/h");

        Console.WriteLine("\n class Cat");
        Cat cat = new Cat("Whiskers", 3, "Gray");
        cat.Meow();
        cat.Eat();

        Console.WriteLine("\n class book");
        book book = new book("Brave New World", "Aldous Huxley", 1932, 311);
        book.DisplayInfo();
    }
}
}