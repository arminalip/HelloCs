using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.Attack();
            dog.SayHi();
            dog.Run();

        }
    }

    public interface IAnimals
    {
        void Run();
    }

    interface IDogCommands : IAnimals
    {
        void Sit();
        void Stay();
        void Attack();

        string DogName
        {
            set;
            get;
        }
    }

    class Animals
    {
        string AnimalName;
        public void SayHi()
        {
            Console.WriteLine("Hi from the animals class");
        }
    }

    class Dogs : Animals, IDogCommands
    {
        private string DogBreed;

        public void Stay()
        {
            Console.WriteLine("Dog is staying!");
        }

        public void Sit()
        {
            Console.WriteLine("Dog is sitting!");
        }

        public void Attack()
        {
            Console.WriteLine("Dog is Attacking!");
        }

        public void Run()
        {
            Console.WriteLine("Animal is Running!");
        }

        public string DogName { get; set; }
    }


}
