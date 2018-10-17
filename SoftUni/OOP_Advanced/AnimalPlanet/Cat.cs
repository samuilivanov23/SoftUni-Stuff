using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPlanet
{
    class Cat : Animal
    {
        public Cat(int age, string name)
            :base(age, name)
        {}

        public string MakeNoise()
        {
            return $"Meow! + {base.MakeNoise()}";
        }

        public string MakeTrick()
        {
            return $"No trick for you! I'm too lazy!";
        }
    }
}
