namespace PokeApi
{
    public class VersionEncounterDetail
    {
        public NamedApiResource<Version> Version { get; set; }
        public int MaxChance { get; set; }
        public Encounter EncounterDetails { get; set; }
    }
}