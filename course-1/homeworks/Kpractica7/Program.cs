using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kpractica7
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("шарик");
            dog.Eat();
            dog.Bark();
            dog.Speak();
            dog.Move();
            var cat = new Cat("Мурка");
            cat.Eat();
            cat.Meow();
            cat.Speak();
            var transport = new Transport();
            var car = new Car();
            var tesla = new ElectricCar();

            transport.Drive();
            car.Drive();
            tesla.Drive();

        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name=name;
            Console.WriteLine($"Созданно живот");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} ест");
        }
        public virtual void Speak()
        {
            Console.WriteLine("Животные издают звук");
        }
        public virtual void Move()
        {
            Console.WriteLine("Животное двигается");
        }


    }
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public void Bark()
        {
            Console.WriteLine("Собака лает");
        }
        public override void Speak()
        {
            Console.WriteLine("Собака говорит: Гав-гав!");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Собака бежит по дороге.");
        }
    }
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public void Meow()
        {
            Console.WriteLine("Кошка говорит: Мяу!");
        }
        public override void Speak()
        {
            Console.WriteLine("Кошка мяукает");
        }
    }
        public class Transport
        {
            public virtual void Drive() => Console.WriteLine("Машина едет по дороге");
        }
        public class Car : Transport
        {
            public override void Drive() => Console.WriteLine("Машина едет по дороге");
        }
        public class ElectricCar : Car
        {
            public override void Drive() => Console.WriteLine("Электромобиль тихо едет на батарее");

        }
    } 
