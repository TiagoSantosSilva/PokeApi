using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class Pokemon
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("DexNumber")]
        public int DexNumber { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Height")]
        public float Height { get; set; }

        [JsonProperty("Weight")]
        public float Weight { get; set; }

        [JsonProperty("Types")]
        public string Type { get; set; }
    }
}
