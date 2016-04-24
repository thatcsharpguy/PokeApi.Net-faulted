namespace PokeApi
{
    public class NatureStatAffect
    {
        public int MaxChange { get; set; }
        public NamedAPIResource<Nature> Nature { get; set; }
    }
}