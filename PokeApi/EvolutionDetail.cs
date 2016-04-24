namespace PokeApi
{
    public class EvolutionDetail
    {
        public NamedApiResource<Item> Item { get; set; }
        public NamedApiResource<EvolutionTrigger> Trigger { get; set; }
        public NamedApiResource<Gender> Gender { get; set; }
        public NamedApiResource<Item> HeldItem { get; set; }
        public NamedApiResource<Move> KnownMove { get; set; }
        public NamedApiResource<Type> KnownMoveType { get; set; }
        public NamedApiResource<Location> Location { get; set; }
        public int MinLevel { get; set; }
        public int MinHappiness { get; set; }
        public int MinBeauty { get; set; }
        public int MinAffection { get; set; }
        public bool NeedsOverworldRain { get; set; }
        public NamedApiResource<PokemonSpecies> PartySpecies { get; set; }
        public int RelativePhysicalStats { get; set; }
        public string TimeOfDay { get; set; }
        public NamedApiResource<PokemonSpecies> TradeSpecies { get; set; }
        public bool TurnUpsideDown { get; set; }
    }
}