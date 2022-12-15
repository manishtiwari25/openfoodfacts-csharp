using OpenFoodFacts.DotNet.Wrapper.Interfaces;
using OpenFoodFacts.DotNet.Wrapper.Models;
using System.Text.Json;

namespace OpenFoodFacts.DotNet
{
    public class OpenFoodFactsApiClient : IOpenFoodFactsApiClient
    {
        private const string API_URL = "https://world.openfoodfacts.org/api/v0";

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _apiUrl;

        public OpenFoodFactsApiClient(IHttpClientFactory clientFactory, string apiUrl)
        {
            _httpClientFactory = clientFactory;
            _apiUrl = apiUrl;
            if (string.IsNullOrEmpty(apiUrl))
            {
                _apiUrl = API_URL;
            }
        }

        public async Task<ProductResponse> FetchProductByCode(string code)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"{_apiUrl}/product/{code}.json");
            var stringContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<ProductResponse>(stringContent);
            }
            throw new Exception(stringContent);
        }
    }
}
