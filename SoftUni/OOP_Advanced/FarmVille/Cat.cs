using System;
using System.Collections.Generic;
using System.Text;

namespace FarmVille
{
    class Cat : Felime
    {
        public string Breed { get; set; }

        public Cat(string animalName, string animalType, double animalWight, int foodEaten, string livingRegion, string breed) 
            : base(animalName, animalType, animalWight, foodEaten, livingRegion)
        {
            this.Breed = breed;
        }

        public override string ToString()
        {
            return $"Cat[{base.AnimalName}, {base.AnimalType}, {base.AnimalWeight}, {LivingRegion}, {Breed}]";
        }

        public override void MakeSound()
        {
            Console.WriteLine("MEOW...");
        }
    }
}
