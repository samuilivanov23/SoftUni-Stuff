using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmVille
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Animalinput = Console.ReadLine();
            List<string> tokens = Animalinput.Split(' ').ToList();
            Animal animal;

            switch (tokens[0])
            {
                case "Cat":
                    animal = new Cat(tokens[1], tokens[0], double.Parse(tokens[2]), 0, tokens[3], tokens[4]);
                    break;
                case "Tiger":
                    animal = new Tiger(tokens[1], tokens[0], double.Parse(tokens[2]), 0, tokens[3]);
                    break;
                case "Zebra":
                    animal = new Zebra(tokens[1], tokens[0], double.Parse(tokens[2]), 0, tokens[3]);
                    break;
                case "Mouse":
                    animal = new Mouse(tokens[1], tokens[0], double.Parse(tokens[2]), 0, tokens[3]);
                    break;
                default:
                    throw new InvalidOperationException("KUR...");
            }

            string FoodInput = Console.ReadLine();
            List<string> foodTokens = FoodInput.Split(' ').ToList();

            Food food;

            switch (foodTokens[0])
            {
                case "Vegetable":
                    food = new Vegetable(int.Parse(foodTokens[1]));
                    break;
                case "Meet":
                    food = new Meet(int.Parse(foodTokens[1]));
                    break;
                default:
                    throw new InvalidOperationException("KUR....");
            }

            if (animal is Tiger)
            {
                if (!(food is Meet))
                {
                    throw new InvalidOperationException("Ei IVAKIS vnimavaq");
                }
                else
                {
                    animal.EatFood(food.Quantity);
                }
            }
            else if ((animal is Mouse) || (animal is Zebra))
            {
                if (!(food is Vegetable))
                {
                    throw new InvalidOperationException("Ei IVAKIS vnimavaq");
                }
                else
                {
                    animal.EatFood(food.Quantity);
                }
            }
            else
            {
                animal.EatFood(food.Quantity);
            }
        }
    }
}
