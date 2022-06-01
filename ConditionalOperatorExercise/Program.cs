using System;

namespace ConditionalOperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "Even Number" : "Odd Number");
        }
    }
}
