namespace PokeApi
{
    public class PokemonAbility 
    {
        public bool IsHidden {get; set;}
        public int Slot {get; set;}
        public NamedAPIResource<Ability> Ability {get; set;}
    }
}