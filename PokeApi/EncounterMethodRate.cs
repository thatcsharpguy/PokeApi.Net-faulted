using System.Collections.Generic;

namespace PokeApi
{
    public class EncounterMethodRate
    {
        public EncounterMethod EncounterMethod { get; set; }
        public List<EncounterVersionDetails> VersionDetails { get; set; }
    }
}