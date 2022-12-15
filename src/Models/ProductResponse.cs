using System.Text.Json.Serialization;

namespace OpenFoodFacts.DotNet.Wrapper.Models
{
    public class ProductResponse
    {
        [JsonPropertyName("product")]
        public Product Product { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("status_verbose")]
        public string StatusVerbose { get; set; }
    }
}
