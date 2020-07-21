using FreeBelarus.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public interface IWebCrawlerService
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();

        Task<Post> GetPostAsync(string uri);

        Task<string> GetJsonAsync();
    }
}