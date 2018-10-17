using System;
using System.Collections.Generic;
using System.Text;

namespace WorkersExercise
{
    public abstract class BaseEmployee
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.EmployeeAddress = employeeAddress;
        }

        public void Show()
        {
            Console.WriteLine($"{this.EmployeeID} + {this.EmployeeName} + {this.EmployeeAddress}");
        }

        public abstract double CalculateSalary(int workingHours);

        public abstract string GetDepartment(int workingHours);


    }
}
