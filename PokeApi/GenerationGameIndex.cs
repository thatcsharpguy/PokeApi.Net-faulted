namespace PokeApi
{
    public class GenerationGameIndex
    {
        public int GameIndex { get; set; }
        public NamedApiResource<Generation> Generation { get; set; }
    }
}