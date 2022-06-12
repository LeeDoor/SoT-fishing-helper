namespace Sea_of_Thieves_helper
{
    public class Species
    {
        public string Name { get;private set; }
        public string Picture { get;private set; }
        public string SpecialFishingMethod { get; private set; }
        public Dictionary<string, FishCost> Cost { get; private set; }

        public Species(string name, string specialFishingMethod, Dictionary<string, FishCost> cost, string picture)
        {
            Name = name;
            SpecialFishingMethod = specialFishingMethod;
            Cost = cost;
            Picture = picture;
        }
    }
}