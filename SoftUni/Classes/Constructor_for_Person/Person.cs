using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_for_Person
{
    class Person
    {
        public int age;
        public string name;

        public Person()
        {
            this.age = 1;
            this.name = "No name";
        }

        public Person(int age)
            :this()
        {
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
    }
}
