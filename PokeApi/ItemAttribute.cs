using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokeApi
{
    public class ItemAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NamedAPIResource<Item>> Items { get; set; }

        public List<Name> Names { get; set; }

        public List<Description> Descriptions { get; set; }
    }
}
