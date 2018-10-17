using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        private List<double> grades;

        public  List<double> Grades
        {
            get { return grades; }
            set
            {
                if(value.Where(x => x < 0).ToList().Count > 0)
                {
                    throw new ArgumentException("It must be grater than 0!");
                }
                grades = value;
            }
        }

        public Person()
        {
            this.grades = new List<double>();
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Invalid first name!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Invalid last name!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid age! (More than 0)");
                }

                this.age = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 460.00)
                {
                    throw new ArgumentException("Invalid salary! (More than 460)");
                }

                this.salary = value;
            }
        }
    }
}
