namespace PokeApi
{
    public class Stat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GameIndex { get; set; }

        public bool IsBattleOnly { get; set; }
        public MoveStatAffectSets AffectingMoves { get; set; }

        public NatureStatAffectSets AffectingNatures { get; set; }
    }
}