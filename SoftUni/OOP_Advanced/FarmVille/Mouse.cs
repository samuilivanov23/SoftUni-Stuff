using System;
using System.Collections.Generic;
using System.Text;

namespace FarmVille
{
    class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWight, foodEaten, livingRegion)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void MakeSound()
        {
            Console.WriteLine("squeeze");
        }
    }
}
