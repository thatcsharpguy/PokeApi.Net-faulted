namespace PokeApi
{
    public class FlavorBerryMap
    {
        public int Potency { get; set; }
        public NamedApiResource<Berry> Berry { get; set; }
    }
}