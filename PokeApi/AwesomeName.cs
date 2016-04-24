using System.Collections.Generic;

namespace PokeApi
{
	public class AwesomeName
	{
		/// <summary>
		/// The localized "scientific" name for an API resource in a specific language.
		/// </summary>
		/// <value>The awesome name1.</value>
		public string AwesomeName1 { get; set; }

		/// <summary>
		/// The language this "scientific" name is in.
		/// </summary>
		/// <value>The language.</value>
		public NamedAPIResource<Language> Language { get; set; }
	}

}