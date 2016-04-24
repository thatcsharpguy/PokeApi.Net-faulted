namespace PokeApi
{
    public class PokemonAbility
    {
        public bool IsHidden { get; set; }
        public int Slot { get; set; }
        public NamedApiResource<Ability> Ability { get; set; }
    }
}