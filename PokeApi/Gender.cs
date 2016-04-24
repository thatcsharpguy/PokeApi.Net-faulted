using System.Collections.Generic;

namespace PokeApi
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PokemonSpeciesGender> PokemonSpeciesDetails { get; set; }
        public List<NamedAPIResource<PokemonSpecies>> RequiredForEvolution { get; set; }
    }
}