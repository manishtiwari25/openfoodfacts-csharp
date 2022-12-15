using System.Text.Json.Serialization;

namespace OpenFoodFacts.DotNet.Wrapper.Models
{
    public class Ingredient
    {
        [JsonPropertyName("from_palm_oil")]
        public string FromPalmOil { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        [JsonPropertyName("percent")]
        public string Percent { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("vegan")]
        public string Vegan { get; set; }

        [JsonPropertyName("vegetarian")]
        public string Cegetarian { get; set; }
    }
}
