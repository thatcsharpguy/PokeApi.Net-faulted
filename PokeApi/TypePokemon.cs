namespace PokeApi
{
    public class TypePokemon
    {
        public int Slot { get; set; }
        public NamedAPIResource<Pokemon> Pokemon { get; set; }
    }
}