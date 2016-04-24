using System.Collections.Generic;

namespace PokeApi
{
    public class Item 
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int Cost{get;set;}
        public int FlingPower {get;set;}
        public ItemFlingEffect FlingEffect {get;set;}
        public List<NamedAPIResource<ItemAttribute>> Attributes {get;set;}
        public ItemCategory Category{get;set;}
        public List<VerboseEffect> EffectEntries{get;set;}
        public List<VersionGroupFlavorText> FlavorTextEntries{get;set;}
        public List<GenerationGameIndex> GameIndices{get;set;}
        public List<Name> Names{get;set;}
        public ItemSprites Sprites {get;set;}
        public List<NamedAPIResource<Pokemon>> HeldByPokemon{get;set;}
        public List<APIResource<EvolutionChain>> BabyTriggerFor{get;set;}
    }

}