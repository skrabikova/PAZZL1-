using System;
namespace Kpractica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- ЗАДАНИЕ 1 ----");
            void SayHello()
            {
                Console.WriteLine("Привет, мир!");
            }

            SayHello();
            Console.WriteLine(" ---- ЗАДАНИЕ 2 ----");
            void Greet(string name)
            {
                Console.WriteLine("Привет," + name + "!");
            }
            Greet("Анатолий");
            Greet("Афродита");
            Greet("Алиса");
            Console.WriteLine(" ---- ЗАДАНИЕ 3 ----");
            void PrintPerson(string name, int age, string city)
            {
                Console.WriteLine($"Name: {name} Age: {age} City: {city}");
            }
            PrintPerson("Егор", 15, "Москва");
            PrintPerson("Мария", 25, "Санкт-Петербург");
            void PrintPerso(string name, int age = 18, string hobby = "не указанно")
            {
                Console.WriteLine($"Имя: {name} Возраст: {age} Хобби: {hobby}");
            }
            PrintPerso("Макс", 20, "футболл");
            PrintPerso("федор", 23);
            PrintPerso("Настя");
            Console.WriteLine("--- ЗАДАНИЕ 4 ----");
            int Square(int x)
            {
                int square = x * x;
                return square;
            }
            int result = Square(8);
            Console.WriteLine("квадрат числа:" + result);
            Console.WriteLine(" ---- ЗАДАНИЕ 6 ----");
            int Add(int a, int b)
            {
                return a + b;
            }
            int Subtract(int a, int b)
            { return a - b; }
            int Multiply(int a, int b)
            {
                return a * b;
            }
            int Divide(int a, int b)
            {
                return a / b;
            }
            int sum = Add(5, 3);
            Console.WriteLine($"Сумма: {sum}");
            int difference = Subtract(5, 3);
            Console.WriteLine($"Разница: {difference}");

        }
    }
}
