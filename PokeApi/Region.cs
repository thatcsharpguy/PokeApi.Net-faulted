using System.Collections.Generic;

namespace PokeApi
{
	public class Region
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public NamedAPIResource<Location> Locations { get; set; }
	}


}