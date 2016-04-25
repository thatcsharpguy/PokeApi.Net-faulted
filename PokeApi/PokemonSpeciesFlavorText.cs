using Newtonsoft.Json;

namespace PokeApi
{
    public class PokemonSpeciesFlavorText
    {

        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }
        public NamedApiResource<Language> Language { get; set; }
        public NamedApiResource<Version> Version { get; set; }
    }
}