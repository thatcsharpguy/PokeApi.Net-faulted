using System.Collections.Generic;

namespace PokeApi
{
    public class EvolutionChain
    {
        public int Id { get; set; }
        public NamedAPIResource<Item> BabyTriggerItem { get; set; }
        public ChainLink Chain {get;set;}
    }

    public class ChainLink  
    {
        public bool IsBaby { get; set; }
        public NamedAPIResource<PokemonSpecies> Species { get; set; }
        public EvolutionDetail EvolutionDetails { get; set; }
        public List<ChainLink> EvolvesTo { get; set; }
    }

    public class EvolutionDetail
    {
        public NamedAPIResource<Item> Item { get; set; }
        public NamedAPIResource<EvolutionTrigger> Trigger { get; set; }
        public NamedAPIResource<Gender> Gender { get; set; }
        public NamedAPIResource<Item> HeldItem { get; set; }
        public NamedAPIResource<Move> KnownMove { get; set; }
        public NamedAPIResource<PokeApi.Type> KnownMoveType { get; set; }
        public NamedAPIResource<Location> Location { get; set; }
        public int MinLevel { get; set; }
        public int MinHappiness{ get; set; }
        public int MinBeauty { get; set; }
        public int MinAffection{ get; set; }
        public bool NeedsOverworldRain { get; set; }
        public NamedAPIResource<PokemonSpecies> PartySpecies { get; set; }
        public int RelativePhysicalStats { get; set; }
        public string TimeOfDay { get; set; }
        public NamedAPIResource<PokemonSpecies> TradeSpecies { get; set; }
        public bool TurnUpsideDown { get; set; }
    }

    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PokemonSpeciesGender> PokemonSpeciesDetails { get; set; }
        public List<NamedAPIResource<PokemonSpecies>> RequiredForEvolution { get; set; }
    }

    public class PokemonSpeciesGender
    {
        public int Rate { get; set; }
        public NamedAPIResource<PokemonSpecies> PokemonSpecies { get; set; }
    }

    public class EvolutionTrigger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Name> Names { get; set; }
        public List<NamedAPIResource<PokemonSpecies>> PokemonSpecies{ get; set; }
    }
}