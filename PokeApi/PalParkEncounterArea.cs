using System.Collections.Generic;

namespace PokeApi
{
	public class PalParkEncounterArea
	{
		/// <summary>
		/// The base score given to the player when the referenced Pokémon is caught during a pal park run.
		/// </summary>
		/// <value>The base score.</value>
		public int BaseScore { get; set; }

		/// <summary>
		/// The base rate for encountering the referenced Pokémon in this pal park area.
		/// </summary>
		/// <value>The rate.</value>
		public int Rate { get; set; }

		/// <summary>
		/// The pal park area where this encounter happens.
		/// </summary>
		/// <value>The area.</value>
		public NamedAPIResource<PalParkArea> Area { get; set; }

		public List<PokemonSpeciesFlavorText> FlavorTextEntries { get; set; }

		public List<Description> FormDescriptions { get; set; }

		public Genus Genera { get; set; }

		public List<NamedAPIResource<Pokemon>> Varieties { get; set; }
	}






}