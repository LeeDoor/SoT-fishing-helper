namespace Sea_of_Thieves_helper
{
    public class Species
    {
        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string Description { get; private set; }
        public FishCost[] Costs { get; private set; }
        public Rectangle[] FishingSpot { get; private set; }

        public Species(string name, string specialFishingMethod, string picture, FishCost[] costs, Rectangle[] fishingSpot)
        {
            Name = name;
            Description = specialFishingMethod;
            Costs = costs;
            Picture = picture;
            FishingSpot = fishingSpot;
        }
    }
}