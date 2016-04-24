using System.Collections.Generic;

namespace PokeApi
{
	public class PokemonEntry
	{
		public int EntryNumber { get; set; }
		public List<NamedAPIResource<PokemonSpecies>> PokemonSpecies { get; set; }
		public NamedAPIResource<Region> Region { get; set; }
		public NamedAPIResource<VersionGroup> VersionGroup { get; set; }
	}




}