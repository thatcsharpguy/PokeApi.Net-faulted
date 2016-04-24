namespace PokeApi
{
    public class PokemonSpeciesFlavorText
    {
        public string FlavorText { get; set; }
        public NamedAPIResource<Language> Language { get; set; }
        public NamedAPIResource<Version> Version { get; set; }
    }
}