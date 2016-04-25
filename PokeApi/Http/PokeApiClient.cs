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

        public async Task<T> GetByUrl<T>(string url)
        {
            string endpoint;
            if (UrlOfType.TryGetValue(typeof(T), out endpoint))
            {
                return await url.GetJsonAsync<T>();
            }
            throw new Exception("Support for " + typeof(T) + " is not implemented yet :(");
        }

//        public async Task<T> Get<T>(int id)
//        {
//            var a = V2Endpoint.AppendPathSegment("");
//            a.
//            return await GetByUrl(V2Endpoint.AppendPathSegment(
//        }



        #region static Dictionary<Type, string> UrlOfType = new Dictionary<Type, string> { [...] };
        static Dictionary<System.Type, string> UrlOfType = new Dictionary<System.Type, string>
        {
//            { typeof(ContestEffect     ), "contest-effect"       },
//            { typeof(SuperContestEffect), "super-contest-effect" },
//            { typeof(Characteristic    ), "characteristic"       },

            { typeof(Berry        ), "berry"          },
            { typeof(BerryFirmness), "berry-firmness" },
            { typeof(BerryFlavor  ), "berry-flavor"   },

//            { typeof(ContestType), "contest-type" },

            { typeof(EncounterMethod        ), "encounter-method"          },
            { typeof(EncounterCondition     ), "encounter-condition"       },
            { typeof(EncounterConditionValue), "encounter-condition-value" },

            { typeof(EvolutionChain  ), "evolution-chain"   },
            { typeof(EvolutionTrigger), "evolution-trigger" },

            { typeof(Generation  ), "generation"    },
            { typeof(Pokedex     ), "pokedex"       },
            { typeof(Version ), "version"       },
            { typeof(VersionGroup), "version-group" },

            { typeof(Item           ), "item"              },
            { typeof(ItemAttribute  ), "item-attribute"    },
            { typeof(ItemCategory   ), "item-category"     },
            { typeof(ItemFlingEffect), "item-fling-effect" },
            { typeof(ItemPocket     ), "item-pocket"       },

            { typeof(Move           ), "move"              },
//            { typeof(MoveAilment    ), "move-ailment"      },
//            { typeof(MoveBattleStyle), "move-battle-style" },
//            { typeof(MoveCategory   ), "move-category"     },
            { typeof(MoveDamageClass), "move-damage-class" },
            { typeof(MoveLearnMethod), "move-learn-method" },
//            { typeof(MoveTarget     ), "move-target"       },

            { typeof(Location    ), "location"      },
            { typeof(LocationArea), "location-area" },
            { typeof(PalParkArea ), "pal-park-area" },
            { typeof(Region      ), "region"        },

            { typeof(Ability       ), "ability"         },
            { typeof(EggGroup      ), "egg-group"       },
            { typeof(Gender        ), "gender"          },
            { typeof(GrowthRate    ), "growth-rate"     },
            { typeof(Nature        ), "nature"          },
//            { typeof(PokeathlonStat), "pokeathlon-stat" },
            { typeof(Pokemon       ), "pokemon"         },
            { typeof(PokemonColor ), "pokemon-color"   },
            { typeof(PokemonForm   ), "pokemon-form"    },
//            { typeof(PokemonHabitat), "pokemon-habitat" },
            { typeof(PokemonShape  ), "pokemon-shape"   },
            { typeof(PokemonSpecies), "pokemon-species" },
            { typeof(Stat          ), "stat"            },
            { typeof(PokemonType   ), "type"            },

            { typeof(Language), "language" }
        };
        #endregion
    }
}
