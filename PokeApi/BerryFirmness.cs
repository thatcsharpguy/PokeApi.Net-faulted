using System.Collections.Generic;

namespace PokeApi
{
    public class BerryFirmness
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NamedAPIResource<Berry>> Berries { get; set; }
        public List<Name> Names { get; set; }
    }
}