using System.Collections.Generic;

namespace PokeApi
{
	public class PokemonShape
	{
		public int Id { get; set; }
		public string Name { get; set; }

		/// <summary>
		/// The "scientific" name of this Pokémon shape listed in different languages.
		/// </summary>
		/// <value>The awesome names.</value>
		public List<AwesomeName> AwesomeNames { get; set; }

		/// <summary>
		/// The name of this Pokémon shape listed in different languages.
		/// </summary>
		/// <value>The names.</value>
		public List<Name> Names { get; set; }

		/// <summary>
		/// A list of the Pokémon species that have this shape.
		/// </summary>
		/// <value>The pokemon species.</value>
		public List<NamedAPIResource<PokemonSpecies>> PokemonSpecies { get; set; }
	}
}