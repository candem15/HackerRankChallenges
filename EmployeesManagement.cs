using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestConsoleApp
{
/*
2. C#: Employees Management
Given a list of data, implement the following 3 methods using LINQ
in a class that allows for managing employees:

1. AverageAge ForEach company-calculates the average age of
employees for each unique company and returns the results as
a Dictionary<string, int> sorted by key, where Key[string] is
the unique company name, and Value[int] is the average age of
employees in this company. The average age is rounded to the
nearest whole number.

2. CountOfEmployeesForEach company - calculates the count of
employees for each unique company and returns the results as
a Dictionary<string, int> sorted by key, where Key[string] is
the unique company name, and Value[int] is the count of
employees in this company.

3. OldestAgeForEach company - finds the oldest aged employee for
each unique company and returns the results as
a Dictionary<string, Employee> sorted by key, where
Key[string] is the unique company name, and Value[Employee]
is the oldest employee in this company.

Here is the description of the Employee class:
• FirstName [string] - the first name of the employee.
• LastName[string] - the last name of the employee.
• Company [string] - the company of the employee.
• Age [int] - the age of the employee.

Your implementation of the class will be tested by a stubbed code
on several input files. The input file contains parameters for the
function calls (i.e., the employee data). The functions will be called
with those parameters, and the result of their executions will be
printed to the standard output by the stubbed code.
*/
    public class Solution
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string companyName="";
            foreach (var employee in employees)
            {
                if (!dictionary.ContainsKey(employee.Company))
                {
                    companyName=employee.Company;
                    dictionary.Add(companyName,Convert.ToInt32(employees.Where(x=>x.Company==companyName).Average<Employee>(x=>x.Age)));

                }
            }
            var ordered = dictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            return ordered;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string companyName="";
            int age=0;
            int count=0;
            foreach (var employee in employees)
            {
                if (!dictionary.ContainsKey(employee.Company))
                {
                    companyName=employee.Company;
                    foreach (var emp in employees)
                    {
                        if(emp.Company==companyName)
                        {
                            age+=emp.Age;
                            count++;
                        }
                    }
                    dictionary.Add(companyName,employees.Where(x=>x.Company==companyName).Count<Employee>());
                    count=0;
                    age=0;
                }
            }
            var ordered = dictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            return ordered;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, Employee> dictionary = new Dictionary<string, Employee>();
            string companyName="";
            foreach (var employee in employees)
            {
                if (!dictionary.ContainsKey(employee.Company))
                {
                    companyName=employee.Company;
                    dictionary.Add(companyName,employees.Where(x=>x.Company==companyName).OrderByDescending(x=>x.Age).FirstOrDefault());
                }
            }
            var ordered = dictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            return ordered;
        }

        public static void Main()
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }


}
