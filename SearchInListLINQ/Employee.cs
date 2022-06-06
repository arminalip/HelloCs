using System;
using System.Collections.Generic;
namespace SearchInListLINQ
{
    public class Employees
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private decimal salary;
        private int age;
        private List<int> appraisal;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public List<int> Appraisal
        {
            get { return appraisal; }
            set { appraisal = value; }
        }
        #region DisplayEmployees
        public static void Display(List<Employees> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, {employee.Salary}, {employee.Age}");
            }
            Console.WriteLine("\n---------------\n");
        }
        #endregion

        #region DisplayWithAppraisal
        public static void DisplayWithAppraisal(List<Employees> employees, string message, bool displayCount)
        {
            int index = 0;
            if (displayCount)
                Console.WriteLine($"Found ({employees.Count}) employees");
            if (message != string.Empty)
            {
                Console.WriteLine(message);
                Console.WriteLine("----------------------------------------------------");
            }
            foreach (var employee in employees)
            {
                index++;
                Console.Write($"{index}) {employee.FirstName} {employee.LastName}, {employee.Salary}, {employee.Age}, last 5 apparisals |");
                foreach (var app in employee.Appraisal)
                {
                    Console.Write(app + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
        #endregion
    }
}
