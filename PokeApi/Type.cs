using System.Collections.Generic;

namespace PokeApi
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeRelations DamageRelations { get; set; }
        public List<GenerationGameIndex> GameIndices { get; set; }
        public NamedAPIResource<Generation> Generation { get; set; }
        public NamedAPIResource<MoveDamageClass> MoveDamageClass { get; set; }
        public List<Name> Names { get; set; }
        public TypePokemon Pokemon { get; set; }
        public List<NamedAPIResource<Move>> Moves { get; set; }
    }
}