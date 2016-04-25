using Newtonsoft.Json;

namespace PokeApi
{
    public class PalParkEncounterSpecies
    {

        [JsonProperty("base_score")]
        public int BaseScore { get; set; }
        public int Rate { get; set; }

        [JsonProperty("pokemon_species")]
        public NamedApiResource<PokemonSpecies> PokemonSpecies { get; set; }
    }
}