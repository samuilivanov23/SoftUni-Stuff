using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Stamat", 20);
            Console.WriteLine(person.Name);

            Creature creature = new Creature("Stamat100", 150, "Junglata");
            Console.WriteLine(creature.Name);
        }
    }
}
