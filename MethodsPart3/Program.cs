using System;

namespace MethodsPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            string guestName = "";

            Console.WriteLine("Hello there, what is your name?");

            guestName = Console.ReadLine();

            if (guestName == string.Empty)
                WelcomeGuest();
            else
            {
                WelcomeGuest(guestName);
            }
        }

        static void WelcomeGuest()
        {
            Console.WriteLine("Dear Guest, Welcome!");
        }
        static void WelcomeGuest(string name)
        {
            Console.WriteLine($"Dear {name}, Welcome!");
        }
    }
}
