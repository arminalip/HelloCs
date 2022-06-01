using System;

namespace MathOperations
{
    public delegate void MathDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            MathDelegate performMathOperations = null;
            performMathOperations += Add;
            performMathOperations += Multiply;
            performMathOperations += Divide;
            performMathOperations += Substract;
            performMathOperations += Remainder;

            performMathOperations(20, 3);
        }

        public static void Add(int x, int y) => Console.WriteLine($"{x} + {y} = " + (x + y));
        public static void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = " + (x * y));
        public static void Divide(int x, int y) => Console.WriteLine($"{x} / {y} = " + ((double)x / (double)y));
        public static void Substract(int x, int y) => Console.WriteLine($"{x} - {y} = " + (x - y));
        public static void Remainder(int x, int y) => Console.WriteLine($"{x} % {y} = " + (x % y));
    }

}
