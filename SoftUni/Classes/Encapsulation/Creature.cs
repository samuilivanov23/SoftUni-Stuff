using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Creature
    {
        private string name;
        private int age;
        private string areal;

        public Creature()
        {}

        public Creature(string name, int age, string areal)
        {
            Name = name;
            Age = age;
            Areal = areal;
        }


        public string Name
        {
            get { return name;}
            private set { name = value; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public string Areal
        {
            get { return areal; }
            set { areal = value; }
        }

    }
}
