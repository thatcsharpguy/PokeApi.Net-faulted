﻿using System.Collections.Generic;

namespace PokeApi
{
    public class ItemPocket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NamedApiResource<ItemCategory>> Categories { get; set; }
        public List<Name> Names { get; set; }
    }
}