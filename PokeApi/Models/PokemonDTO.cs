using System;
using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class PokemonDTO
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("DexNumber")]
        public int DexNumber { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
