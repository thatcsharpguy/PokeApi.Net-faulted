using System.Collections.Generic;

namespace PokeApi
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMainSeries { get; set; }
        public NamedApiResource<Generation> Generation { get; set; }
        public List<Name> Names { get; set; }
        public List<VerboseEffect> EffectEntries { get; set; }
        public List<VersionGroupFlavorText> FlavorTextEntries { get; set; }
        public List<AbilityPokemon> Pokemon { get; set; }
    }
}