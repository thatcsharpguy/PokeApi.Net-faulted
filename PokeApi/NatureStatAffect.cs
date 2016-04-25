using Newtonsoft.Json;

namespace PokeApi
{
    public class NatureStatAffect
    {

        [JsonProperty("max_change")]
        public int MaxChange { get; set; }
        public NamedApiResource<Nature> Nature { get; set; }
    }
}