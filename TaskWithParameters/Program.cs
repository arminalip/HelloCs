using System;
using System.Threading.Tasks;
using System.Threading;

namespace TaskWithParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(new Action<object>(SayHi), "Armin");
            task1.Start();

            Task task2 = new Task(delegate (object name)
            {
                Console.WriteLine("Welcome Back " + name);
            }, "Armin");
            task2.Start();

            Task task3 = new Task(n => { Console.WriteLine("Welcome Back " + n); }, "Armin");
            task3.Start();

            Console.ReadLine();
        }

        public static void SayHi(object name)
        {
            Console.WriteLine("Welcome back " + name);
        }

    }
}
