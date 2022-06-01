using System;
using System.Threading.Tasks;
using System.Timers;

namespace CheckingTasksStatus
{
    class Program
    {
        static Timer timer;
        static Task task;
        static void Main(string[] args)
        {
            task = new Task(() =>
            {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        });
            task.Start();
            

            timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 10;
            timer.Enabled = true;

            Console.ReadLine();


        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (task.Status == TaskStatus.Running)
            {
                Console.WriteLine("Task is running.....");
            }
            else if (task.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("Task is complete");
                timer.Enabled = false;
            }
        }
    }
}
