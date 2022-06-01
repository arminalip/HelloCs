using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Install-Package "System.ValueTuple"

            int x = 0;

            (int, string, int) James = (30000, "LeBron", 130);
            Console.WriteLine(James.Item1);
            Console.WriteLine(James.Item2);
            Console.WriteLine(James.Item3);

        }
    }
}
