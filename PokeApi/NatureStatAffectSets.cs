using System.Collections.Generic;

namespace PokeApi
{
    public class NatureStatAffectSets
    {
        public List<NatureStatAffect> Increase { get; set; }
        public List<NatureStatAffect> Decrease { get; set; }
    }
}