using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Pet : BirdthDate
    {
        public string BirdthDate { get; }
        public string Name { get; private set; }

        public Pet(string name, string BirdthDate)
        {
            this.Name = name;
            this.BirdthDate = BirdthDate;
        }

    }
}
