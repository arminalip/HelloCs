using System;
using System.Collections.Generic;

namespace EmployeeInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple in Tuple in Tuple
            var empInfo = new Tuple<string, string, string, string, string, string, string,
Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal,
Tuple<int, int, int, int, int>>>("", "", "", "", "", "", "",
new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal, Tuple<int, int, int, int, int>>
(0m, 1m, 2m, 3m, 4m, 5m, 6m, Tuple.Create(100, 200, 300, 400, 500)));

            Console.WriteLine(empInfo.Rest.Rest);
        }
    }
}
