using System.Collections.Generic;

namespace PokeApi
{
    public class MoveStatAffectSets
    {
        public List<MoveStatAffect> Increase { get; set; }
        public List<MoveStatAffect> Decrease { get; set; }
    }
}