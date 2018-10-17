using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPlanet
{
    public abstract class Animal : IMakeTrick, IMakeNoise
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public string MakeNoise()
        {
            return $"My name is {this.Name}. I am {this.Age} old.";
        }

        public string MakeTrick()
        {
           return $"Look at my trick!";
        }
    }
}
