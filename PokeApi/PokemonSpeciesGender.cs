using Newtonsoft.Json;

namespace PokeApi
{
    public class PokemonSpeciesGender
    {
        public int Rate { get; set; }
        [JsonProperty("pokemon_species")]
        public NamedApiResource<PokemonSpecies> PokemonSpecies { get; set; }
    }
}