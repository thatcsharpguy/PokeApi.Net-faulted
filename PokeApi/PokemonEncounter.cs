using System.Collections.Generic;

namespace PokeApi
{
	public class PokemonEncounter
	{
		public NamedAPIResource<Pokemon> Pokemon { get; set; }

		public List<VersionEncounterDetail> VersionDetails { get; set; }
	}





}