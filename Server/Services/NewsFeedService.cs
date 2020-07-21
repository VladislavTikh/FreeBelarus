using FreeBelarus.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public class NewsFeedService : INewsFeedService
    {
        private IWebCrawlerService _webCrawler;
        private IDeserializer _deserialiser;

        public NewsFeedService(IWebCrawlerService webCrawler, IDeserializer deserializer)
        {
            _webCrawler = webCrawler;
        }

        public Task<IEnumerable<Post>> GetAllPosts()
        {
            throw new NotImplementedException();
        }
    }
}
