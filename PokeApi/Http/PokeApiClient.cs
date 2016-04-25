using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;

namespace PokeApi.Http
{
    public class PokeApiClient
    {
        const string V2Endpoint = "http://pokeapi.co/api/v2/";
        public async Task<Pokemon> GetPokemon(int id)
        {
            var url = V2Endpoint.AppendPathSegments("pokemon", id.ToString());
            var pokemon = await url.GetJsonAsync<Pokemon>();
            return pokemon;
        }

        public async Task<Type> GetType(string name)
        {
            var url = V2Endpoint.AppendPathSegments("types", name);
            var type = await url.GetJsonAsync<Type>();
            return type;
            
        }
    }
}
