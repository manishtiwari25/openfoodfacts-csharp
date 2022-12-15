using System.Text.Json.Serialization;

namespace OpenFoodFacts.DotNet.Wrapper.Models
{
    public class NutrientLevels
    {
        [JsonPropertyName("fat")]
        public string Fat { get; set; }

        [JsonPropertyName("salt")]
        public string Salt { get; set; }

        [JsonPropertyName("saturated-fat")]
        public string SaturatedFat { get; set; }

        [JsonPropertyName("sugars")]
        public string Sugars { get; set; }
    }
}
