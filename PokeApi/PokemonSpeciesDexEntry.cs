namespace PokeApi
{
    public class PokemonSpeciesDexEntry
    {
        /// <summary>
        ///     The index number within the Pokédex.
        /// </summary>
        /// <value>The entry number.</value>
        public int EntryNumber { get; set; }

        /// <summary>
        ///     The Pokédex the referenced Pokémon species can be found in.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
    }
}