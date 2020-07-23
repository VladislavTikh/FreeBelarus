using FreeBelarus.Server.Services;
using FreeBelarus.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private INewsFeedService _feedService;

        public PostsController(INewsFeedService feedService)
        {
            _feedService = feedService;
        }

        [HttpGet]
        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _feedService.GetAllPostsAsync();
        }
    }
}
