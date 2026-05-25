using System;
namespace Kpractica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 1");
            int[] noom = new int[5];
            noom[0] = 34;
            noom[1] = 45;
            noom[2] = 32;
            noom[3] = 12;
            noom[4] = 100;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(noom[i]);
            }
            Console.WriteLine("ЗАДАНИЕ 2");
            int[] boom = { 2, 4, 5, 4, 5, 3 };
            double summ = 0;
            foreach (int pull in boom)
            {
                summ = summ + pull;
            }
            Console.WriteLine("сумма всех оценок:" + summ);
            double sredne = summ / 5;
            Console.WriteLine("среднее арифметическо:" + sredne);
            Console.WriteLine("ЗАДАНИЕ 3");
            int[] good = new int[8];
            Random random = new Random();
            Console.WriteLine("Создан массив рандомных чисел");
            for (int h = 0; h < 8; h++)
            {
                good[h] = random.Next(1, 100);
                Console.WriteLine(good[h]);
            }
            Console.WriteLine("ЗАДАНИЕ 4");
            Console.WriteLine("выводем список с помощью foreach");
            string[] fructs = { "яблоко", "абрикос", "банан", "груша", "дыня" };
            foreach (string fr in fructs)
            {
                Console.WriteLine("фрукты:" + fr);
            }
            Console.WriteLine("УРОВЕНЬ 2");
            Console.WriteLine("ЗАДАНИЕ 5");
            Console.WriteLine("Создаем двумерный массив размером 3 на 3");
            int[,] tabl = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};
            for (int d = 0; d < 3; d++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine(tabl[d, a]);
                }
            }
            Console.WriteLine("ЗАДАНИЕ 6");
            Console.WriteLine("Вводим пароль");
            int one = 0;
            do
            {
                Console.Write("Введите пароль из четырех цифр:");
                int password = int.Parse(Console.ReadLine());
                if (password == 1234)
                {
                    Console.WriteLine("Вы ввели верный пароль");
                    break;
                }
                else
                {
                    Console.WriteLine("вы ошиблись");
                }
            }
            while (one != 1234);
        }
    }
}
