using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Pesho";
            person.LastName = "Peshov";
            try
            {
                person.Age = 10;
                person.Salary = 500.00;
                person.Grades.Add(5);
                person.Grades.Add(-4.7);
                person.Grades.Add(3.25);
                Console.WriteLine(person.Grades.Average().ToString(".00"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
