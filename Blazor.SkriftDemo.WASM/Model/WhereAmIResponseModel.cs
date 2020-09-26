using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blazor.SkriftDemo.WASM.Model
{
    public class WhereAmIResponseModel
    {
        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("request_id")]
        public string Request_Id { get; set; }

        [JsonPropertyName("lat")]
        public decimal Latitude { get; set; }

        [JsonPropertyName("lon")]
        public decimal Longitude { get; set; }

        [JsonPropertyName("water")]
        public bool IsWater { get; set; }
    }
}
