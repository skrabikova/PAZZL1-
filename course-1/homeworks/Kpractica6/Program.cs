using System;
using System.Security.Policy;
using System.Web;
namespace Kpractica6
{
}
public class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Pages { get; private set; }
    public Book()
    {
        Title = "Неизвестно";
        Author = "Неизвестен";
        Pages = 0;
    }
    public Book (string title)
    {
        Title = title; 
    }
    public Book(string title, string author) 
    {
        Author = author;
        Title = title;
    }
    public Book(string title, string author, int pages) 
    {
        Author = author;
        Title = title;
        Pages=pages;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, Автор: {Author}, Страниц: {Pages}");
    }
}
class Program
{
    public static void Main()
    {
        var book1 = new Book();
        var book2 = new Book("Мертвые души");
        var book3 = new Book("Преступление и наказание", "Федор Достоевский");
        var book4 = new Book("1984", "Джордж Оруэлл", 450);
        book1.PrintInfo();
        book2.PrintInfo();
        book3.PrintInfo();
        book4.PrintInfo();
        Console.WriteLine("---- ЗАДАНИЕ 2 ----");
        var car1 = new Car();
        var car2 = new Car("mazda");
        var car3 = new Car("BMW", "E34");
        car1.PrintInfoo();
        car2.PrintInfoo();
        car3.PrintInfoo();
    }
}
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Speed { get; set; }
    public Car() : this("Неизвестно", "Неизвестно", 0)
    {
    }
    public Car(string brand) : this(brand, "Неизвестно", 0)
    {
    }
    public Car(string brand, string model) : this(brand, model, 0)
    {
    }
    private Car(string brand, string model, int speed)
    {
        Brand = brand;
        Model = model;
        Speed = speed;
    }

    public void PrintInfoo()
    {
        Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Скорость: {Speed} км/ч");
    }
}
public class Plaer
{
    public string Name { get; set; }
    public int Level { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"Игрок: {Name}, Уровень: {Level}");
    }
    public override bool Equals(object obj)
    {
        if (obj is Player other)
        {
            return Name == other.Name && Level == other.Level;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return GetHashCode.Combine(Name, Level);
    }
}
