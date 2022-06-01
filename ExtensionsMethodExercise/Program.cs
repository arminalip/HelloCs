using System;

namespace ExtensionsMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime(2000, 11, 1);
            Console.WriteLine(myDate.MyCustomFormat());
        }
    }

    static class MyExtensions
    {
        public static string MyCustomFormat(this DateTime date)
        {
            return string.Format("{0:dddd dd\nMMMM yyyy}", date);
        }
    }
}
