using FreeBelarus.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public class NewsFeedService : INewsFeedService
    {
        private IWebCrawlerService _webCrawler;
        private IDeserializer<Post> _deserializer;

        public NewsFeedService(IWebCrawlerService webCrawler, IDeserializer<Post> deserializer)
        {
            _webCrawler = webCrawler;
            _deserializer = deserializer;
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            var content = await _webCrawler.GetJsonContentAsync();
            return  await _deserializer.Deserialize(content);           
        }
    }
}
