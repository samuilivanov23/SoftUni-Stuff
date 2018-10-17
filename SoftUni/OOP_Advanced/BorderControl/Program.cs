using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void LackOfFood()
        {
            List<IBuyer> listOfBuyers = new List<IBuyer>();
            List<string> listOfNames = new List<string>();

            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string input_ = Console.ReadLine();
                List<string> tokens_ = input_.Split().ToList();
                switch (tokens_.Count)
                {
                    case 4:
                        IBuyer citizenBuyer = new Citizen(tokens_[2], int.Parse(tokens_[1]), tokens_[0], tokens_[3]);
                        listOfNames.Add(tokens_[0]);
                        listOfBuyers.Add(citizenBuyer);
                        break;
                    case 3:
                        IBuyer rebelBuyer = new Rebel(int.Parse(tokens_[1]), tokens_[0], tokens_[2]);
                        listOfBuyers.Add(rebelBuyer);
                        listOfNames.Add(tokens_[0]);
                        break;
                }                
            }

            string inputName = Console.ReadLine();

            while (inputName != "End")
            {
                for(int i = 0; i < listOfNames.Count; i++)
                {
                    if(listOfNames[i] == inputName)
                    {
                        listOfBuyers[i].BuyFood();
                    }
                }

                inputName = Console.ReadLine();
            }

            int outPut = 0;

            foreach(var item in listOfBuyers)
            {
                outPut += item.Food;
            }

            Console.WriteLine(outPut);
        }

        public static void BirdthDate()
        {
            List<BirdthDate> listOfBirdthDates = new List<BirdthDate>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> tokens = input.Split().ToList();

                switch (tokens[0])
                {
                    case "Citizen":
                        BirdthDate citizenID = new Citizen(tokens[3], int.Parse(tokens[2]), tokens[1], tokens[4]);
                        listOfBirdthDates.Add(citizenID);
                        break;
                    case "Pet":
                        BirdthDate petBirdthDate = new Pet(tokens[1], tokens[2]);
                        listOfBirdthDates.Add(petBirdthDate);
                        break;
                }

                input = Console.ReadLine();
            }

            string yearofBirdth = Console.ReadLine();

            foreach (var item in listOfBirdthDates)
            {
                List<string> temp = item.BirdthDate.Split('/').ToList();
                if (temp[temp.Count - 1] == yearofBirdth)
                {
                    Console.WriteLine(item.BirdthDate);
                }
            }
        }
    }
}
