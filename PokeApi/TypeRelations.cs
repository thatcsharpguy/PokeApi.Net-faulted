using System.Collections.Generic;

namespace PokeApi
{
    public class TypeRelations
    {
        public List<NamedAPIResource<Type>> NoDamageTo { get; set; }
        public List<NamedAPIResource<Type>> HalfDamageTo { get; set; }
        public List<NamedAPIResource<Type>> DoubleDamageTo { get; set; }
        public List<NamedAPIResource<Type>> NoDamageFrom { get; set; }
        public List<NamedAPIResource<Type>> HalfDamageFrom { get; set; }
        public List<NamedAPIResource<Type>> DoubleDamageFrom { get; set; }
    }
}