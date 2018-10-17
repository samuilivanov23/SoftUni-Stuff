using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Robot : IId
    {
        public string ID { get; }

        public string Model { get; private set; }

        public Robot(string id, string model)
        {
            this.Model = model;
            this.ID = id;
        }
    }
}
