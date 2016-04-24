namespace PokeApi
{
    public class PalParkEncounterSpecies
    {
        public int BaseScore { get; set; }
        public int Rate { get; set; }
        public NamedAPIResource<PokemonSpecies> PokemonSpecies { get; set; }
    }
}