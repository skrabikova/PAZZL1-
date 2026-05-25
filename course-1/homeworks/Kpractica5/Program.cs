 using System;
using System.Collections.Generic;

namespace Kpractica5
{
}
public class Car
{
    public string Brand { get; set; }
    public int Speed { get; private set; } = 20;
    public Car(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }
    public void Accelerate() => Speed += 10;
}

class Program
{
    public static void Main()
    {
        var car = new Car("Audi", 50);
        Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed}");
    }
}
public class Book
{
    public string Tatle { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public Book(string tatle, string author, int pages)
    {
        Tatle = tatle;
        Author = author;
        Pages = pages;
    }
    public void Read(int pages)
    {
        Console.WriteLine($"вы прочитали {pages} страниц из {Pages}");
        var book1 = new Book(Tatle = "Евгений Онегин", Author = "А.С. Пушкин", Pages = 300);
        var book = new Book("Евгений Онегин", "А.С. Пушкин", 300);
    }

}
public class Library
{
    private List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"");
    }
}