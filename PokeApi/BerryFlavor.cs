using System.Collections.Generic;

namespace PokeApi
{
    public class BerryFlavor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FlavorBerryMap> Berries { get; set; }
    }
}