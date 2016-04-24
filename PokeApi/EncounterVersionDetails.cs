namespace PokeApi
{
    public class EncounterVersionDetails
    {
        public int Rate { get; set; }
        public NamedAPIResource<Version> Version { get; set; }
    }
}