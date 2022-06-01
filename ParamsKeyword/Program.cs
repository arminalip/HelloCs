using System;
using System.Collections.Generic;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopThroughArray(10, 50, 25, 3);
            LoopThroughArray("Armin", "Kanye", "Jay");
            LoopThroughArray(DateTime.Now, new DateTime(2020, 12, 01));
        }

        public static void LoopThroughArray<T>(params T[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------------");
        }
    }
}
