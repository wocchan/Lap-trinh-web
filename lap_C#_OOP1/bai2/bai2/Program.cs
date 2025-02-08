using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    // lop truu tuong Animal
    abstract class Animal
    {
        public string Type { get; private set; }

        public Animal(string type)
        {
            Type = type;
        }

        public abstract string MakeSound(); // phuong thuc truu tuong tra ve am thanh dong vat
        public abstract string GetInfo(); // phuong thuc truu tuong tra ve thong tin dong vat
    }

    // lop Dog ke thua Animal
    class Dog : Animal
    {
        public string Name { get; private set; }
        public string Breed { get; private set; }

        public Dog(string name, string breed) : base("Mammal")
        {
            Name = name;
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "Woof Woof!"; // am thanh cua cho
        }

        public override string GetInfo()
        {
            return $"Dog - Name: {Name}, Breed: {Breed}, Type: {Type}"; // tra ve thong tin cho
        }
    }

    // lop Cat ke thua Animal
    class Cat : Animal
    {
        public string Name { get; private set; }

        public Cat(string name) : base("Mammal")
        {
            Name = name;
        }

        public override string MakeSound()
        {
            return "Meow!"; // am thanh cua meo
        }

        public override string GetInfo()
        {
            return $"Cat - Name: {Name}, Type: {Type}"; // tra ve thong tin meo
        }

        public void Climb(string place)
        {
            Console.WriteLine($"{Name} is climbing {place}."); // hanh dong leo cua meo
        }
    }

    // lop Duck ke thua Animal
    class Duck : Animal
    {
        public string Name { get; private set; }

        public Duck(string name) : base("Bird")
        {
            Name = name;
        }

        public override string MakeSound()
        {
            return "Quack!"; // am thanh cua vit
        }

        public override string GetInfo()
        {
            return $"Duck - Name: {Name}, Type: {Type}"; // tra ve thong tin vit
        }

        public void Swim(string waterBody)
        {
            Console.WriteLine($"{Name} is swimming in the {waterBody}."); // hanh dong boi cua vit
        }
    }

    // kiem thu cac lop
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog("Buddy", "Chihuahua");
            Console.WriteLine(dog.GetInfo());
            Console.WriteLine(dog.MakeSound());

            Cat cat = new Cat("Whiskers");
            Console.WriteLine(cat.GetInfo());
            Console.WriteLine(cat.MakeSound());
            cat.Climb("tree");

            Duck duck = new Duck("Donald");
            Console.WriteLine(duck.GetInfo());
            Console.WriteLine(duck.MakeSound());
            duck.Swim("pond");
        }
    }


}
