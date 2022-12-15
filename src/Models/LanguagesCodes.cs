using System.Text.Json.Serialization;

namespace OpenFoodFacts.DotNet.Wrapper.Models
{
    public class LanguagesCodes
    {
        [JsonPropertyName("en")]
        public string EN { get; set; }

        [JsonPropertyName("fr")]
        public string FR { get; set; }

        [JsonPropertyName("pl")]
        public string PL { get; set; }
    }
}
