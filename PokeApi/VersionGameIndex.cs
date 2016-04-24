namespace PokeApi
{
    public class PokemonAbility 
    {
        public int GameIndex {get; set;}
        public NamedAPIResource<Version> Ability {get; set;}
    }
}