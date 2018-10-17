using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Citizen : IId, BirdthDate, IBuyer
    {
        public string ID { get; }
        public int Age { get; private set; }
        public string Name { get; private set; }

        public string BirdthDate { get; }
        public int Food { get; set;}

        public Citizen(string id, int age, string name, string birdthDate)
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.BirdthDate = birdthDate;
            this.Food = 0;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
