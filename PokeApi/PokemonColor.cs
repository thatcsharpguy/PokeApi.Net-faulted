using System.Collections.Generic;

namespace PokeApi
{
    public class PokemonColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Name> Names { get; set; }

        /// <summary>
        ///     A list of the Pokémon species that have this color.
        /// </summary>
        /// <value>The pokemon species.</value>
        public List<NamedApiResource<PokemonSpecies>> PokemonSpecies { get; set; }
    }
}