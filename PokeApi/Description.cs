using System.Collections.Generic;

namespace PokeApi
{
	public class Description
	{
		/// <summary>
		/// The localized description for an API resource in a specific language.
		/// </summary>
		public string Description1 { get; set; }

		/// <summary>
		/// The language this name is in.
		/// </summary>
		public NamedAPIResource<Language> Language { get; set; }
	}




}