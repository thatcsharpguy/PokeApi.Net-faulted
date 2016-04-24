using System;
using System.Threading.Tasks;

namespace Flurl_Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bulb = new PokeApi.Http.PokeApiClient();
            var blb = bulb.GetPokemon(1);
            Task.WaitAll(blb);
            var pkmn = blb.Result;

            Console.WriteLine(pkmn.Name);
            Console.Read();
        }
    }
}