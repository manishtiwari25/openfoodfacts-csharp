using System.Text.Json.Serialization;

namespace OpenFoodFacts.DotNet.Wrapper.Models
{
    public class SelectedImage
    {
        [JsonPropertyName("display")]
        public SelectedImageItem Display { get; set; }

        [JsonPropertyName("small")]
        public SelectedImageItem Small { get; set; }

        [JsonPropertyName("thumb")]
        public SelectedImageItem Thumb { get; set; }
    }
}
