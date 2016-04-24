namespace PokeApi
{
    public class VersionGameIndex 
    {
        public int GameIndex {get; set;}
        public NamedAPIResource<Version> Version {get; set;}
    }
}