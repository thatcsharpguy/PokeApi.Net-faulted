namespace PokeApi
{
    public class Nature
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public NamedAPIResource<Stat> DecreasedStat { get; set; }
        public NamedAPIResource<Stat> IncreasedStat { get; set; }
        public NamedAPIResource<BerryFlavor> HatesFlavor { get; set; }
        public NamedAPIResource<BerryFlavor> LikesFlavor { get; set; }
    }
}