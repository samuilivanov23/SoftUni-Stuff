using System;
using System.Collections.Generic;
using System.Text;

namespace FarmVille
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        protected Mammal(string animalName, string animalType, double animalWight, int foodEaten, string livingRegion) 
            : base(animalName, animalType, animalWight, foodEaten)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{base.GetType().Name}[{base.AnimalName}, {base.AnimalType}, {base.AnimalWeight}, {base.FoodEaten} {LivingRegion}]";
        }
    }
}
