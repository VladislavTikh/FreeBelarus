using FreeBelarus.Shared.Models;
using MatBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetJsonAsync()
        {
            var uri = _client.BaseAddress + $"/{_extractorId}/json/latest?_apikey={_apiKey}";
            var message  =  await _client.GetAsync(uri);
            return await message.Content.ReadAsStringAsync();
        }

        public Task<Post> GetPostAsync(string uri)
        {
            throw new NotImplementedException();
        }
    }
}
