using System.Collections.Generic;

namespace PokeApi
{
    public class ChainLink
    {
        public bool IsBaby { get; set; }
        public NamedApiResource<PokemonSpecies> Species { get; set; }
        public EvolutionDetail EvolutionDetails { get; set; }
        public List<ChainLink> EvolvesTo { get; set; }
    }
}