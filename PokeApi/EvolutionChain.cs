namespace PokeApi
{
    public class EvolutionChain
    {
        public int Id { get; set; }
        public NamedAPIResource<Item> BabyTriggerItem { get; set; }
        public ChainLink Chain {get;set;}
    }
}