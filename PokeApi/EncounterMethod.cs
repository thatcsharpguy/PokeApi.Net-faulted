using System.Collections.Generic;

namespace PokeApi
{
    public class EncounterMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public List<Name> Names { get; set; }
    }
}