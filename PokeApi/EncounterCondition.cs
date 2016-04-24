using System.Collections.Generic;

namespace PokeApi
{
	public class EncounterCondition
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Name> Names { get; set; }
		public List<NamedAPIResource<EncounterConditionValue>> Values { get; set; }
	}
}