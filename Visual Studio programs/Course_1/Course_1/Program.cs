using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_1
{
    public class Animal
    {
        public string sound = "GRRR";
        public int age = 10;
        public string animal_name = "Luki";
        public string animal_type = "Dog";
        public Animal()
        {
            this.age = age;
            this.sound = sound;
            this.animal_type = animal_type;
            this.animal_name = animal_name;
        }
        public void Show_AnimalType()
        {
            Console.WriteLine("animal type: {0}", this.animal_type);
        }
        public void Show_AnimalName()
        {
            Console.WriteLine("animal name: {0}", this.animal_name);
        }
        public void Show_Years_Sound()
        {
            Console.WriteLine("godini: {0}, Kak rumjish: {1}", this.age, this.sound);
        }
    }
    class TestAnimal
    {
        static void Main(string[] args)
        {
  
        Animal animal1 = new Animal();
        animal1.Show_AnimalType();
        animal1.Show_AnimalName();
        animal1.Show_Years_Sound();

              
        }
    }
}
