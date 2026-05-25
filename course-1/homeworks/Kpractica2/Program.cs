using System;
namespace Kpractica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("Число положительное");
            }
            else if (number < 0)
            {
                Console.WriteLine("Число отрицательное");
            }
            else if (number == 0)
            {
                Console.WriteLine("Число равно нулю");
            }
            Console.WriteLine(" ---- ЗАДАНИЕ 2 ----");
            Console.Write("Введите ваш возраст:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0)
            {
                Console.WriteLine("вы совершенно летний");
            }
            else
            {
                Console.WriteLine("вы не совершенно летний");
            }
            Console.WriteLine(" ---- ЗАДАНИЕ 3 ----");
            int num = 7;
            if (num % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
            Console.WriteLine(" ---- ЗАДАНИЕ 4 ----");
            int a = 5;
            int b = -2;
            if (a > 0 && b > 0)
            {
                Console.WriteLine("Оба числа положительные");
            }
            else if (a > 0 || b > 0)
            {
                Console.WriteLine("Хотя бы одно число положительное");
            }
            Console.WriteLine("---- ЗАДАНИЕ 5 ----");
            Console.WriteLine("Введите оценку ученика по пятибальной системе:");
            int grade = int.Parse(Console.ReadLine());
            if (grade < 3)
            {
                Console.WriteLine("Неудовлетворительно");
            }
            else if (grade == 3)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else if (grade == 4)
            {
                Console.WriteLine("Хорошо");
            }
            else if (grade == 5)
            {
                Console.WriteLine("Отлично");
            }
            else
            {
                Console.WriteLine("Ошибка: оценка должна быть от 2 до 5!");
            }
        }
    }
}
