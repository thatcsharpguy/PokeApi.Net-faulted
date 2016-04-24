namespace PokeApi
{
    public class NatureStatAffect
    {
        public int MaxChange { get; set; }
        public NamedApiResource<Nature> Nature { get; set; }
    }
}