using System.Collections.Generic;

namespace PokeApi
{
	public class Generation
	{
		public int Id{ get; set;}
		public int Name{ get; set;}
		public List<NamedAPIResource<Ability>> Abilities{ get; set;}
		public List<Name> Names{ get; set;}
		public NamedAPIResource<Region> MainRegion{ get; set; }
		public List<NamedAPIResource<Move>> Moves{ get; set; }
	}

}