using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public class WebCrawlerService : IWebCrawlerService
    {
        private HttpClient _client;
        private string _extractorId = "ca96e5a0-edd6-41fe-b1c0-a6b42b504b34";
        private string _apiKey;

        public WebCrawlerService(string apiKey)
        {
            _apiKey = apiKey;
            _client = new HttpClient
            {
                BaseAddress = new Uri(@"https://data.import.io/extractor")
            };
        }

        public async Task<string> GetJsonContentAsync()
        {
            var uri = _client.BaseAddress + $"/{_extractorId}/json/latest?_apikey={_apiKey}";
            var resposne = await _client.GetAsync(uri);
            return await resposne.Content.ReadAsStringAsync();
        }
    }
}
