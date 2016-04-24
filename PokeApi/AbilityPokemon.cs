namespace PokeApi
{
    public class AbilityPokemon
    {
        public bool IsHidden { get; set; }
        public int Slot { get; set; }
        public NamedAPIResource<Pokemon> Pokemon { get; set; }
    }
}