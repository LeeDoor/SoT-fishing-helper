using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_of_Thieves_helper
{
    public class Fish
    {
        public string Name { get; }
        public string Description { get; }
        public BaitType Bait { get; }
        public string Picture { get; }
        public Species[] _species = new Species[5];
        public Fish(string name, string globalFishingMethod, BaitType bait, string picture, Species[] species)
        {
            Name = name;
            Description = globalFishingMethod;
            _species = species;
            Picture = picture;
            Bait = bait;
        }
    }
}
