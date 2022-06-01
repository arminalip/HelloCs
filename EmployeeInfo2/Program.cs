using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeInfo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> filteredlist = new List<Employees>();
            List<Employees> listOfEmployees = new List<Employees>
            {
                new Employees { EmployeeID=1150, FirstName="Jack",LastName="Steven", Salary=5000m, Age=35,Appraisal = new List<int>{7,7,8,9,7} },
                new Employees { EmployeeID=1150, FirstName="Debora",LastName="Watson", Salary=10000m, Age=45,Appraisal = new List<int>{9,9,8,9,8} },
                new Employees { EmployeeID=1150, FirstName="Claire",LastName="Adam", Salary=7500m, Age=32,Appraisal = new List<int>{9,7,8,9,7} },
                new Employees { EmployeeID=1150, FirstName="Michael",LastName="Rob", Salary=3500m, Age=22,Appraisal = new List<int>{6,7,8,7,7} },
                new Employees { EmployeeID=1150, FirstName="Matthew",LastName="Forest", Salary=4500m, Age=28,Appraisal = new List<int>{7,7,6,6,7} },
                new Employees { EmployeeID=1150, FirstName="Charles",LastName="Kris", Salary=8000m, Age=27,Appraisal = new List<int>{8,9,7,8,8} },
                new Employees { EmployeeID=1150, FirstName="Robert",LastName="Wilson", Salary=8000m, Age=28,Appraisal = new List<int>{8,9,8,9,9} },
                new Employees { EmployeeID=1150, FirstName="Emma",LastName="Brooks", Salary=6000m, Age=23,Appraisal = new List<int>{8,6,9,9,7} },
                new Employees { EmployeeID=1150, FirstName="Jennifer",LastName="Blake", Salary=3000m, Age=38,Appraisal = new List<int>{6,7,7,6,6} },
                new Employees { EmployeeID=1150, FirstName="Terry",LastName="Loyd", Salary=9000m, Age=49,Appraisal = new List<int>{9,9,9,8,7} },
                new Employees { EmployeeID=1150, FirstName="Adam",LastName="Spencer", Salary=7000m, Age=33,Appraisal = new List<int>{8,8,8,6,7} },
                new Employees { EmployeeID=1150, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} }
            };

            Employees.DisplayWithAppraisal(listOfEmployees, "All Employess");

            //filteredlist = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age >= 40).ToList();

            //filteredlist = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age >= 40 || e.Salary>=8000).ToList();

            //filteredlist = listOfEmployees.Where(e => e.Salary > 4000 && e.Appraisal[0] < 8).ToList();


            //Salary is greater than or equal to 6000 and age greater than 40
            //filteredlist = (from emp in listOfEmployees
            //                where emp.Salary >= 6000 && emp.Age > 40
            //                select emp).ToList();
            //Employees.DisplayWithAppraisal(filteredlist, "Salary higher than 6000 and age above 40");

            //Salary is greater than or equal to 6000 and age greater than 40 or salary is greater than or equal 8000
            //filteredlist = (from emp in listOfEmployees
            //                where emp.Salary >= 6000 && emp.Age > 40
            //                || emp.Salary>= 8000
            //                select emp).ToList();
            //Employees.DisplayWithAppraisal(filteredlist, "Salary higher than 6000  and age above 40 or salary is greater than or equal 8000");


            //foreach (var employee in filteredlist)
            //{
            //    Console.WriteLine(employee);
            //}
            //Console.WriteLine();
            //Employees.DisplayWithAppraisal(filteredlist, "Employess");


            //filteredlist = (from emp in listOfEmployees
            //                where emp.Salary > 4000 && emp.Appraisal[0] < 8
            //                select emp).ToList();

            //Employees.DisplayWithAppraisal(filteredlist, "Employess");




            //filteredlist = (from emp in listOfEmployees
            //                orderby emp.Age descending, emp.Appraisal[0] descending
            //                select emp).ToList();

            //Employees.DisplayWithAppraisal(filteredlist, "Employess");

            //Employees.DisplayWithAppraisal(SortEmployess(listOfEmployees), "Sorted Employees with method");

        }

        //public static List<Employees> SortEmployess(List<Employees> employees)
        //{
        //    var list = from emp in employees
        //               orderby emp.Age descending
        //               select emp;

        //    return list.ToList();
        //}

    }
}
