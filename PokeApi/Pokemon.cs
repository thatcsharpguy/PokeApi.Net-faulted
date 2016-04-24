using System.Collections.Generic;

namespace PokeApi
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public int Height { get; set; }
        public bool IsDefault { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public List<PokemonAbility> Abilities { get; set; }
        public List<NamedApiResource<PokemonForm>> Forms { get; set; }
        public List<VersionGameIndex> GameIndices { get; set; }
        public List<NamedApiResource<Item>> HeldItems { get; set; }
        public List<LocationAreaEncounter> LocationAreaEncounters { get; set; }
        public List<NamedApiResource<Move>> Moves { get; set; }
        public NamedApiResource<PokemonSpecies> Species { get; set; }
        public List<NamedApiResource<Stat>> Stats { get; set; }
        public List<PokemonType> Types { get; set; }
    }
}