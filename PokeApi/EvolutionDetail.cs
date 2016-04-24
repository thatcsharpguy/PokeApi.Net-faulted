namespace PokeApi
{
    public class EvolutionDetail
    {
        public NamedAPIResource<Item> Item { get; set; }
        public NamedAPIResource<EvolutionTrigger> Trigger { get; set; }
        public NamedAPIResource<Gender> Gender { get; set; }
        public NamedAPIResource<Item> HeldItem { get; set; }
        public NamedAPIResource<Move> KnownMove { get; set; }
        public NamedAPIResource<Type> KnownMoveType { get; set; }
        public NamedAPIResource<Location> Location { get; set; }
        public int MinLevel { get; set; }
        public int MinHappiness { get; set; }
        public int MinBeauty { get; set; }
        public int MinAffection { get; set; }
        public bool NeedsOverworldRain { get; set; }
        public NamedAPIResource<PokemonSpecies> PartySpecies { get; set; }
        public int RelativePhysicalStats { get; set; }
        public string TimeOfDay { get; set; }
        public NamedAPIResource<PokemonSpecies> TradeSpecies { get; set; }
        public bool TurnUpsideDown { get; set; }
    }
}