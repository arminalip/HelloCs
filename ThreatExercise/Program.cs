using System;
using System.Threading;

namespace ThreatExercise
{
    class Program
    {
        static Thread t1;
        static void Main(string[] args)
        {
            //t1 = new Thread(new ThreadStart(() => Console.WriteLine("Hello from lambda expression")));
            //t1.Start();

            Thread t2 = new Thread(new ThreadStart(delegate ()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello from the anonymous method assigned to the t2 thread");
                }

	        }));
            t2.Start();
        }
    }
}
