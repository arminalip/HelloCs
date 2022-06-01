using System;
using System.Threading.Tasks;
using System.Threading;

namespace TaskwithRetunValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = new Task<int>(() =>
            {
                int result = 0;
                for (int i = 1; i <= 4; i++)
                {
                    result += i;
                    Console.WriteLine(i);
                }
                return result;
            });
            task.Start();
            Console.WriteLine(task.Result);
            Console.ReadLine();
        }
    }
}
