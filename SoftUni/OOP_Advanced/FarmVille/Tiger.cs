using System;
using System.Collections.Generic;
using System.Text;

namespace FarmVille
{
    class Tiger : Felime
    {
        
        public Tiger(string animalName, string animalType, double animalWight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWight, foodEaten, livingRegion)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAR...");
        }
    }
}
