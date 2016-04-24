using System.Collections.Generic;

namespace PokeApi
{
    public class EvolutionTrigger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Name> Names { get; set; }
        public List<NamedApiResource<PokemonSpecies>> PokemonSpecies { get; set; }
    }
}