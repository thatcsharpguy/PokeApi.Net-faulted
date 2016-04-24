using System.Collections.Generic;

namespace PokeApi
{
    public class LocationAreaEncounter
    {
        public APIResource<LocationArea> LocationArea { get; set; }
        public List<VersionEncounterDetail> VersionDetails { get; set; }
    }
}