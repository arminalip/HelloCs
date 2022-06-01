using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            double div = 0;

            startAgain:
            try
            {
                Console.Write("Enter the first number : ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number : ");
                y = int.Parse(Console.ReadLine());

                div = (double)y / (double)x;
                Console.WriteLine("The result is: " + div);
                goto startAgain;
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero!");
                goto startAgain;
            }

            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input!");
                goto startAgain;
            }
        }
    }
}
