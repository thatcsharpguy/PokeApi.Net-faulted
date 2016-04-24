using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokeApi
{
    public class NatureStatAffectSets
    {
        public List<NatureStatAffect> Increase { get; set; }
        public List<NatureStatAffect> Decrease { get; set; }
    }
}
