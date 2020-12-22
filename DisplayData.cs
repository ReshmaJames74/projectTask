using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTask
{
    class DisplayData
    {
        public void Empdisplay()
        {
            int n;

            Console.WriteLine("Number of company:");
            n = Convert.ToInt32(Console.ReadLine());
      

            var Employees = new List<EmployeeDetails.Employee>
                { 
               new EmployeeDetails.Employee{ EmpId = Convert.ToInt32(Console.ReadLine())},
               new EmployeeDetails.Employee{EmpName = Console.ReadLine()},
               new EmployeeDetails.Employee{CompanyId = Convert.ToInt32(Console.ReadLine())},
               new EmployeeDetails.Employee{ CompanyName = Console.ReadLine()},
               new EmployeeDetails.Employee{ Designation = Console.ReadLine() },
               new EmployeeDetails.Employee{ Department = Console.ReadLine()},
                };
            //int counter = 0;
            //while (counter < 10)
            //{
            //    string CompanyName = null;
            //    Console.WriteLine($"{counter}"+CompanyName);
            //    counter++;
            //}

            string headerLine = string.Join(",", Employees[0].GetType().GetProperties().Select(p => p.Name));
                var dataLines = from emp in Employees
                                let dataLine = string.Join(",", emp.GetType().GetProperties().Select(p => p.GetValue(emp)))
                                select dataLine;
                var csvData = new List<string>();
                csvData.Add(headerLine);
                csvData.AddRange(dataLines);

                string csvFilePath = @"D:\employee.csv";
                System.IO.File.WriteAllLines(csvFilePath, csvData);



            
        }
    }
}
