namespace PokeApi
{
    public class TypePokemon
    {
        public int Slot { get; set; }
        public NamedApiResource<Pokemon> Pokemon { get; set; }
    }
}