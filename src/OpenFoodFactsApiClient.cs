using OpenFoodFacts.DotNet.Wrapper.Interfaces;
using OpenFoodFacts.DotNet.Wrapper.Models;
using System.Net.Http;
using System.Text.Json;

namespace OpenFoodFacts.DotNet
{
    public class OpenFoodFactsApiClient : IOpenFoodFactsApiClient
    {
        private const string API_URL = "https://world.openfoodfacts.org/api/v0";

        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public OpenFoodFactsApiClient(IHttpClientFactory clientFactory, string apiUrl)
        {
            _httpClient = clientFactory.CreateClient();
            _apiUrl = apiUrl;
            if (string.IsNullOrEmpty(apiUrl))
            {
                _apiUrl = API_URL;
            }
        }
        public OpenFoodFactsApiClient(string apiUrl)
        {
            _httpClient = new HttpClient();
            _apiUrl = apiUrl;
            if (string.IsNullOrEmpty(apiUrl))
            {
                _apiUrl = API_URL;
            }
        }

        public OpenFoodFactsApiClient(HttpClient client, string apiUrl)
        {
            _httpClient = client;
            _apiUrl = apiUrl;
            if (string.IsNullOrEmpty(apiUrl))
            {
                _apiUrl = API_URL;
            }
        }

        public async Task<ProductResponse> FetchProductByCode(string code)
        {
            var response = await _httpClient.GetAsync($"{_apiUrl}/product/{code}.json");
            var stringContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<ProductResponse>(stringContent);
            }
            throw new Exception(stringContent);
        }
    }
}
