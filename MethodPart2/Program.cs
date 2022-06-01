using System;

namespace MethodPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passing reference or value

            //string firstName, secondName;
            //firstName = "Taghi";
            //secondName = "Naghi";

            //Console.WriteLine($"Display Inside Main\n---------\n{firstName}\n{secondName}\n\n");
            DisplayName(out string firstName, out string secondName);
            Console.WriteLine($"Display Outside Main\n---------\n{firstName}\n{secondName}\n\n");
        }

        static void DisplayName(out string frstName, out string scndName)
        {
            frstName = "Ali";
            scndName = "Shali";
            Console.WriteLine($"Display Outside Main\n---------\n{frstName}\n{scndName}\n\n");
        }

    }
}
