using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem
{
    class Cargo
    {
        public string type;
        public int tejest;

        public Cargo(int tejest, string type)
        {
            this.type = type;
            this.tejest = tejest;
        }
    }
}
