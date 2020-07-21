using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeBelarus.Server.Services;
using FreeBelarus.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeBelarus.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IWebCrawlerService _webCrawler;

        public PostsController(IWebCrawlerService webCrawler)
        {
            _webCrawler = webCrawler;
        }

        [HttpGet]
        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            var posts = new List<Post>();
            var result = await _webCrawler.GetJsonAsync();
            return posts;
        }
    }
}
