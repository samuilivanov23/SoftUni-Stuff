using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            Family family = new Family();
            Person member = new Person();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').ToList();
                member.Name = input[0];
                member.Age = int.Parse(input[1]);
                family.AddMember(member);
            }

            Person oldestMember = family.GetOldestMmber();
            Console.WriteLine($"{oldestMember.Name} { oldestMember.Age}");
        }
    }
}
