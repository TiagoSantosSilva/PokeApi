using System;
using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class Status
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Code")]
        public int Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }
}
