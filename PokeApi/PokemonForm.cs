namespace PokeApi
{
	public class PokemonForm
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Order { get; set; }
		public int FormOrder { get; set; }
		public bool IsDefault { get; set; }
		public bool IsBattleOnly { get; set; }
		public bool IsMega { get; set; }
		public string FormName { get; set; }
		public NamedAPIResource<Pokemon> Pokemon { get; set; }
		public PokemonFormSprites Sprites { get; set; }
		public NamedAPIResource<VersionGroup> VersionGroup { get; set; }
	}
}