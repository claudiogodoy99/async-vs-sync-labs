

using BenchmarkDotNet.Attributes;

namespace SyncVsAsync
{
    public class RestClient
    {
        private readonly HttpClient _httpClient;

        public RestClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7064/");
        }

        public async Task GetData(string endpoint) {
            await _httpClient.GetAsync(endpoint);
        }
    }
}
