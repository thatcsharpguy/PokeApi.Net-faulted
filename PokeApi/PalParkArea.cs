using System.Collections.Generic;

namespace PokeApi
{
    public class PalParkArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Name> Names { get; set; }
        public List<PalParkEncounterSpecies> PokemonEncounters { get; set; }
    }
}