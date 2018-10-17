using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Chicken
    {
        private string name;
        private int age;
        private int health;

        public Chicken(string name, int age, int health)
        {
            Name = name;
            Age = age;
            Health = health;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Health
        {
            get { return health; }
            private set { value = health; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

    }
}
