namespace PokeApi
{
    public class GenerationGameIndex
    {
        public int GameIndex { get; set; }
        public NamedAPIResource<Generation> Generation { get; set; }
    }
}