using System.Collections.Generic;

namespace PokeApi
{
    public class Version 
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public List<Name> Names{get;set;}
        public NamedAPIResource<VersionGroup> VersionGroup {get;set;}
    }
}