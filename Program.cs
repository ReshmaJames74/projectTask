using System;

namespace ProjectTask
{
    class EmployeeDetails
    {
        public class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public string CompanyName { get; set; }
            public int CompanyId { get; set; }
            public string Designation { get; set; }
            public string Department { get; set; }
        }
    
        static void Main(string[] args)
        {

            DisplayData Data = new DisplayData();
            Data.Empdisplay();

        }
    }
}
