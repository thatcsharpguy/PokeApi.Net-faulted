namespace PokeApi
{
    public class PokemonSpeciesFlavorText
    {
        public string FlavorText { get; set; }
        public NamedApiResource<Language> Language { get; set; }
        public NamedApiResource<Version> Version { get; set; }
    }
}