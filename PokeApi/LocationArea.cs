using System.Collections.Generic;

namespace PokeApi
{
	public class LocationArea
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int GameIndex { get; set; }
		public List<EncounterMethodRate> EncounterMethodRates { get; set; }
		public NamedAPIResource<Region> Location { get; set; }
		public List<Name> Names { get; set; }
		public List<PokemonEncounter> PokemonEncounters { get; set; }
	}




}