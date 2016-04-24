using System.Collections.Generic;

namespace PokeApi
{
    public class MoveDamageClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Description> Descriptions { get; set; }
        public List<NamedAPIResource<Move>> Moves { get; set; }
        public List<Name> Names { get; set; }
    }
}