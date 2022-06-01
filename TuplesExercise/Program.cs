using System;
using System.Collections.Generic;

namespace TuplesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesInformation = new List<Tuple<int, string, string, DateTime>>();
            employeesInformation.Add(new Tuple<int, string, string, DateTime>(3, "Zack", "Posen", new DateTime(2021, 11, 25)));
            employeesInformation.Add(Tuple.Create(1, "Chris", "Evans", new DateTime(2020, 3, 21)));
            employeesInformation.Add(Tuple.Create(4, "Chris", "Pine", new DateTime(2021, 5, 21)));
            employeesInformation.Add(Tuple.Create(2, "Jill", "Valentine", new DateTime(2011, 5, 21)));

            foreach (var employee in employeesInformation)
            {
                Console.WriteLine($"{employee.Item1}, {employee.Item2}, {employee.Item3}, {employee.Item4.ToShortDateString()}");
            }
            Console.WriteLine("------------------------");
            employeesInformation.Sort();
            foreach (var employee in employeesInformation)
            {
                Console.WriteLine($"{employee.Item1}, {employee.Item2}, {employee.Item3}, {employee.Item4.ToShortDateString()}");
            }
        }
    }
}
