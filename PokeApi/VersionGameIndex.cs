namespace PokeApi
{
    public class VersionGameIndex
    {
        public int GameIndex { get; set; }
        public NamedApiResource<Version> Version { get; set; }
    }
}