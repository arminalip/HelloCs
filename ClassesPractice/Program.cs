using System;

namespace ClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Person perOne = new Person();
            perOne.FirstName = "Armin";
            perOne.LastName = "Alipour";
            perOne.Country = "Iran";

            Console.WriteLine($"Hi, {perOne.FirstName} {perOne.LastName} from {perOne.Country}");

            Person perTwo = new Person();
            perTwo.FirstName = "Shalgham";
            perTwo.LastName = "Karafsi";
            perTwo.Country = "Iran";

            Console.WriteLine($"Hi, {perTwo.FirstName} {perTwo.LastName} from {perTwo.Country}");*/

            Panir cheese = new Panir();
            cheese.SayHi();
        }
    }
    class Person
    {
        // It is a bad practice to add public to the variable from the start
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        //Adding properties to each variables
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }


        public string LastName //Adding properties to each variables
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate //Adding properties to each variables
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Country //Adding properties to each variables
        {
            get { return country; }
            set { country = value; }
        }

        public Person() //Default value for each property
        {
            firstName = "Unkown";
            lastName = "Unkown";
            country = "Unkown";
        }
    }

    class Panir
    {
        public void SayHi()
        {
            Console.WriteLine("Hi, from Panir!");
        }
    }
        
}
