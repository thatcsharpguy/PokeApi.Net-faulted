using System.Collections.Generic;

namespace PokeApi
{
    public class Berry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GrowthTime { get; set; }
        public int MaxHarvest { get; set; }
        public int NaturalGiftPower { get; set; }
        public int Size { get; set; }
        public int Smoothness { get; set; }
        public int SoilDryness { get; set; }

        public NamedApiResource<BerryFirmness> Firmness { get; set; }
        public List<FlavorBerryMap> Flavors { get; set; }
        public NamedApiResource<Item> Item { get; set; }
        public NamedApiResource<Type> NaturalGiftType { get; set; }
    }
}