using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_for_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person person = new Person();
            Person person2 = new Person(age);
            Person person3 = new Person(name, age);

            Console.WriteLine($"{person.name} {person.age}");
            Console.WriteLine($"{person2.name} {person2.age}");
            Console.WriteLine($"{person3.name} {person3.age}");
        }
    }
}
