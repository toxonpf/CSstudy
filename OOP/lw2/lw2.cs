namespace lw2
{   
public class Person
{
    protected string Name { get; set; }
    protected string Adress { get; set; }

    protected int _age { get; set; }
    public int Age
    {
        get { return _age; }
        set { _age = value < 0 ? 0 : value; }
    }
    
    public Person(string name, int age, string adress)
    {
        Name = name;
        Age = age;
        Adress = adress;
    }

    public virtual void GetFullName()
    {
        System.Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Адрес: {Adress}");
    }
}

public class Employee : Person
{
    protected string Position { get; set; }
    protected double Salary { get; set; }

    public Employee(string position, double salary, string Name, int Age, string Adress) : 
    base(Name, Age, Adress)
    {
        Position = position;
        Salary = salary < 0 ? 0 : salary;
    }

    public override void GetFullName()
    {
        base.GetFullName();
        System.Console.WriteLine($"Имя: {Name} Должность: {Position}");
    }
}

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Рисуем фигуру");
    }

    public virtual void Name()
    {
        Console.WriteLine("Фигура");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Рисуем круг");
    }

    public override void Name()
    {
        Console.WriteLine("Круг");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Рисуем прямоугольник");
    }

    public override void Name()
    {
        Console.WriteLine("Прямоугольник");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Рисуем треугольник");
    }

    public override void Name()
    {
        Console.WriteLine("Треугольник");
    }
}
}