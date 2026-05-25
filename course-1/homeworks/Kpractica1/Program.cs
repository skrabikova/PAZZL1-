using System;
namespace Kpractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Задание 1:Aрифметические операции над переменными");
            int a = 12;
            int b = 5;
            Console.WriteLine("первое число:" + a);
            Console.WriteLine("второе число:" + b);
            Console.WriteLine("Найдем их сумму разность,произведение, частное и остаток");
            int summ = a + b;
            Console.WriteLine("сумма равна:" + summ);
            int diff = a - b;
            Console.WriteLine("разность равна:" + diff);
            int prod = a * b;
            Console.WriteLine("произведение равно:" + prod);
            int div = a / b;
            Console.WriteLine("частное равно:" + div);
            int mod = a % b;
            Console.WriteLine("остаток равен:" + mod);
            Console.WriteLine("Задание 2:запросите у пользователя имя");
            Console.Write("Как тебя зовут путник:");
            String name = Console.ReadLine();
            Console.WriteLine("ПРИВЕТ!" + name);
            Console.WriteLine("УРОВЕНЬ 2");
            Console.WriteLine("находим сумму");
            Console.Write("Введите любое целое число");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Введите второе любое целое число:");
            int k = int.Parse(Console.ReadLine());
            int sum = h + k;
            Console.WriteLine("сумма равна:" + sum);
            Console.WriteLine("Находим площадь прямоугольника");
            Console.Write("Введите длинну прямоугольника:");
            float wight = float.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника:");
            float height = float.Parse(Console.ReadLine());
            float s = wight * height;
            Console.Write("Площадь прямоугольника:" + s);

        }
    }
}
