 using System;
 using System.Threading;

namespace CreatingThreads
{
    class Program
    {
        static Thread t1;
        static Thread t2;
        static void Main(string[] args)
        {
           // SayHiEnglish(); SayHiSpanish(); //Sequential

            t1 = new Thread(new ThreadStart(SayHiEnglish));
            t1.Name = "Thread number one (English)";
            t1.Start();

            t2 = new Thread(new ThreadStart(SayHiSpanish));
            t2.Name = "Thread number one (Spanish)";
            t2.Start();

        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                //Thread.Sleep(1000);
                if (i == 31)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "is aborted!");
                    t1.Abort();
                }
                else
                {
                    Console.WriteLine(i + "Hi!...");
                }
            }
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                //Thread.Sleep(new TimeSpan(0,0,1));
                Console.WriteLine(i + "Hola!...");
            }
        }
    }
}
