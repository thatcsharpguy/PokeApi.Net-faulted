using System.Collections.Generic;

namespace PokeApi
{
	public class VersionEncounterDetail
	{
		public NamedAPIResource<Version> Version { get; set; }
		public int MaxChance { get; set; }
		public Encounter EncounterDetails { get; set; }
	}
}