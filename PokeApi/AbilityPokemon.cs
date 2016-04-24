namespace PokeApi
{
    public class AbilityPokemon
    {
        public bool IsHidden { get; set; }
        public int Slot { get; set; }
        public NamedApiResource<Pokemon> Pokemon { get; set; }
    }
}