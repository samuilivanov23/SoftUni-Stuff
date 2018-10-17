using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Pokemon
    {
        public string name;
        public string element;

        public Pokemon(string name, string element)
        {
            this.name = name;
            this.element = element;
        }
    }
}
