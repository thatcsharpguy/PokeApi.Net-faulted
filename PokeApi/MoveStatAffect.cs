namespace PokeApi
{
    public class MoveStatAffect
    {
        public int MaxChange { get; set; }
        public NamedApiResource<Move> Move { get; set; }
    }
}