using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            List<Person> persons = new List<Person>();
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').ToList();
                persons.Add(new Person(input[0], input[1], int.Parse(input[2])));
            }
            persons = persons.OrderBy(x=>x.FirstName).ThenBy(y => y.LastName).ToList();
            
            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
