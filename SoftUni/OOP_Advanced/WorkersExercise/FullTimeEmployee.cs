using System;
using System.Collections.Generic;
using System.Text;

namespace WorkersExercise
{
    class FullTimeEmployee : BaseEmployee
    {

        public string EmployeePosition { get; set; }
        public string EmployeeDepartment { get; set; }


        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment)
            :base(employeeID, employeeName, employeeAddress)
        {
            this.EmployeePosition = employeePosition;
            this.EmployeeDepartment = employeeDepartment;
        }

        public void Show()
        {
            Show();
            Console.WriteLine($"{this.EmployeePosition} + {this.EmployeeDepartment}");
        }
        
        public override double CalculateSalary(int workingHours)
        {
            return 250 + (10.80 * workingHours);
        }

        public override string GetDepartment(int workingHours)
        {
            return this.EmployeeDepartment;
        }
    }
}
