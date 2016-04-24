namespace PokeApi
{
    public class PokemonSpeciesGender
    {
        public int Rate { get; set; }
        public NamedApiResource<PokemonSpecies> PokemonSpecies { get; set; }
    }
}