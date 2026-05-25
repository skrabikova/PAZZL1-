using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Kpractica8.Person;
namespace Kpractica8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- ЗАДАНИЕ 1 ---- ");
            var p = new Person();
            p.Name = "Алиса";
            p.Age = 25;
            p.Age = -5;
            Console.WriteLine(" ---- ЗАДАНИЕ 2 ---- ");
            var account = new BankAccount();
            account.Deposit(1000);
            account.ShowBalance();
            account.Withdraw(200);
            account.ShowBalance();
            Console.WriteLine(" ---- ЗАДАНИЕ 3 ---- ");
            var t = new Thermometer();
            t.TemperatureCelsius = 25;
            Console.WriteLine(t.TemperatureFahrenheit);
            Console.WriteLine("---- ЗАДАНИЕ 4");
            var dog = new Dog();
            dog.Eat();  
            dog.Run();    
            dog.Run();
            dog.Run(); 
        }
    }
    public class Person
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Возраст не может быть отрицательным");
            }

        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("имя не может быть пустым");
            }
        }
    }
        public class BankAccount
        {
            private decimal balance;
            public void Deposit(decimal amount)
            {
                balance += amount;
            }
            public void Withdraw(decimal amount)
            {
                if (amount <= balance)
                    balance -= amount;
                else
                    Console.WriteLine("Недостаточно средвств!");
            }
            public void ShowBalance()
            {
                Console.WriteLine($"Баланс:{balance}");
            }
        }
        public class Thermometer
        {
            private decimal temperatureCelsius;
            public decimal TemperatureCelsius
            {
                get { return temperatureCelsius; }
                set
                {
                    if (value <= -273)
                        temperatureCelsius = value;
                    else
                        Console.WriteLine("Температура не может быть ниже -273°C");
                }
            }
            public decimal TemperatureFahrenheit { get { return (temperatureCelsius * 9m / 5m) + 32m; } 

            }
        }
    public class Animal
    {
        protected int energy = 100;
        public void Eat()
        {
            energy += 10;
            Console.WriteLine("Животное поело. Энергия: " + energy);
        }
    }
    public class Dog : Animal
    {
        public void Run()
        {
            energy -= 20;
            Console.WriteLine($"Собака пробежала её энергия: {energy}");
        }
    }
       

    }


