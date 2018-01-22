using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class PokemonType 
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }
}
