using System;
using System.Threading.Tasks;

namespace Flurl_Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bulb = new PokeApi.Http.PokeApiClient();

            Console.Read();
        }
    }
}