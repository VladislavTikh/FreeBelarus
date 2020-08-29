using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public class WebCrawlerService : IWebCrawlerService
    {
        private ImportIOClient.ImportIOClient _client;
        private string _extractorId = "ca96e5a0-edd6-41fe-b1c0-a6b42b504b34";

        public WebCrawlerService(string apiKey)
        {
            _client = new ImportIOClient.ImportIOClient(apiKey);
        }

        public async Task<string> GetJsonContentAsync()
        {
            return await _client.Data.GetLatestRunResultAsync(_extractorId);
        }
    }
}
