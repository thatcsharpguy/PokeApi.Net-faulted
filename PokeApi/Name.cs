using Newtonsoft.Json;

namespace PokeApi
{
    public class Name
    {
        [JsonProperty("name")]
        public string Name1 { get; set; }
        public NamedApiResource<Language> Language { get; set; }
    }
}