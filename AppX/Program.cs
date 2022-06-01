using System;

namespace AppX
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = rand.Next(1, 7);

            Console.WriteLine("Roll Dice? (yes/no)");
            string u = Console.ReadLine();
            u = u.ToLower();
            if (u == "yes")
            {
                Console.WriteLine("New Dice No is: {0}", x);
            }
            else
            {
            }
        }
    }
}
