using System.Collections.Generic;

namespace PokeApi
{
    public class EncounterConditionValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NamedAPIResource<EncounterCondition>> Condition { get; set; }
        public List<Name> Names { get; set; }
    }
}