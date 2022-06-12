using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_of_Thieves_helper
{
    public class Fish
    {
        public string Name { get; private set; }
        public string GlobalFishingMethod { get; private set; }
        private Species[] _species = new Species[5];

        public Fish(string name, string globalFishingMethod, Species[] species)
        {
            Name = name;
            GlobalFishingMethod = globalFishingMethod;
            _species = species;
        }
    }
}
