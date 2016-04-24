namespace PokeApi
{
    public class MoveStatAffect
    {
        public int MaxChange { get; set; }
        public NamedAPIResource<Move> Move { get; set; }
    }
}