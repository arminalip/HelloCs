using System;
using System.Threading.Tasks;
using System.Threading;
namespace TasksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(new Action(SayHi));
            task.Start();

            Task task2 = new Task(delegate ()
            {
                Console.WriteLine("Task 2 is starting");
                Console.WriteLine("Task 2 is running");
                Console.WriteLine("Hi there from Task 2");
                Thread.Sleep(5000);
                Console.WriteLine("Task 2 is complete");

            });

            task2.Start();

            Task task3 = new Task(() =>
            {
                Console.WriteLine("Task 3 is starting");
                Console.WriteLine("Task 3 is running");
                Console.WriteLine("Hi there from Task 2");
                Thread.Sleep(3000);
                Console.WriteLine("Task 3 is complete");


            });

            task3.Start();

            Console.WriteLine("What is your name");
            var name = Console.ReadLine();
            Console.WriteLine("Hi " + name);

            Console.ReadLine();
        }

        public static void SayHi()
        {
            Console.WriteLine("Task 1 is starting");
            Console.WriteLine("Task 1 is running");
            Console.WriteLine("Hi there from Task 1");
            Thread.Sleep(1500);
            Console.WriteLine("Task 1 is complete");
        }
    }
}
