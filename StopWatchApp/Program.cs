using System;
using System.Diagnostics;
namespace StopWatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Loop(900_000_000);
            watch.Stop();

            Console.WriteLine("Milliseconds" + watch.Elapsed.Milliseconds);
            Console.WriteLine("Total Milliseconds" + watch.Elapsed.TotalMilliseconds);
        }

        public static void Loop(long number)
        {
            for (long i = 0; i < number; i++)
            {

            }
            Console.WriteLine("Process done.");
        }

    }
}
