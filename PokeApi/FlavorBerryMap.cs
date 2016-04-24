namespace PokeApi
{
    public class FlavorBerryMap
    {
        public int Potency { get; set; }
        public NamedAPIResource<Berry> Berry { get; set; }
    }
}