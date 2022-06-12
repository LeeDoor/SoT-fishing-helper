namespace Sea_of_Thieves_helper
{
    public class Species
    {
        public string Name { get;private set; }
        public string Picture { get;private set; }
        public string SpecialFishingMethod { get; private set; }
        public FishCost[] Costs { get; private set; }

        public Species(string name, string specialFishingMethod, string picture, FishCost[] costs)
        {
            Name = name;
            SpecialFishingMethod = specialFishingMethod;
            Costs = costs;
            Picture = picture;
        }
    }
}