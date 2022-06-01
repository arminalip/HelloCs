using System;

namespace MethodsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetName();
        }

        static int PerformAddOperation(int a, int b)
        {
            int addResult = 0;
            addResult = a + b;
            return addResult;
        }

        static void DisplayMessage()
        {
            Console.WriteLine("Process is done!");
            Console.WriteLine("by Armin");
            Console.WriteLine("Time: " + DateTime.Now.ToLongTimeString());
        }

        static void GetName()
        {
            string Name = string.Empty;
            Console.WriteLine("What is your name? ");
            Name = Console.ReadLine();
            Welcome(Name);
        }

        static void Welcome(string Name)
        {
            Console.WriteLine("Hello, {0}", Name);

        }
    }
}
