using System.Collections.Generic;

namespace PokeApi
{
    public class ItemCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NamedAPIResource<Item>> Items { get; set; }
        public List<Name> Names { get; set; }
        public NamedAPIResource<ItemPocket> Pocket { get; set; }
    }
}