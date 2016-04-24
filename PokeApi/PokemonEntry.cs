using System.Collections.Generic;

namespace PokeApi
{
    public class PokemonEntry
    {
        public int EntryNumber { get; set; }
        public List<NamedApiResource<PokemonSpecies>> PokemonSpecies { get; set; }
        public NamedApiResource<Region> Region { get; set; }
        public NamedApiResource<VersionGroup> VersionGroup { get; set; }
    }
}