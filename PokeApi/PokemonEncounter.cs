using System.Collections.Generic;

namespace PokeApi
{
    public class PokemonEncounter
    {
        public NamedApiResource<Pokemon> Pokemon { get; set; }

        public List<VersionEncounterDetail> VersionDetails { get; set; }
    }
}