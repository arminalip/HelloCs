using System;
using System.Collections.Generic;

namespace ListofAnimalsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "Lucy";

            Animals cat = new Animals();
            cat.Name = "Hera";

            Animals elephent = new Animals();
            elephent.Name = "Dumbo";

            List<Animals> list = new List<Animals>();
            list.Add(dog);
            list.Add(cat);
            list.Add(elephent);

            foreach (var item in list)
            {
                item.SayHi();
            }
        }
    }

    class Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine(("Hello my name is "+ name));
        }

        public void Feed()
        {
            Console.WriteLine(name + " is now eating");
        }
    }
}
