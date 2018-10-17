using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Rebel : IBuyer
    {
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Group { get; set; }

        public int Food { get; set; }

        public Rebel(int age, string name, string group)
        {
            this.Age = age;
            this.Name = name;
            this.Group = group;
            this.Food = 0;
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
