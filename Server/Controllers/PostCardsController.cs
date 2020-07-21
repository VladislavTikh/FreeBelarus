using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FreeBelarus.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeBelarus.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCardsController : ControllerBase
    {
        private List<PostCard> _postCards;
        public PostCardsController()
        {
            _postCards = new List<PostCard>()
            {
                new PostCard
                {
                    Title = "IWe97%",
                    Description = "Freedom postcard",
                    ImageUri = "../assets/images/we_are_97.jpg",
                    SourceLink = "https://www.instagram.com/ritabardak.art/",
                    AuthorName = "Marharita Tsikhanovich",
                    DownloadLink = "assets/images/we_are_97.jpg"
                },
                new PostCard
                {
                    Title = "IWe97% Version 2",
                    Description = "Freedom postcard",
                    ImageUri = "../assets/images/we_are_97_2.jpg",
                    SourceLink = "https://www.instagram.com/ritabardak.art/",
                    AuthorName = "Marharita Tsikhanovich"
                },
                new PostCard
                {
                    Title = "Freedom Belarus",
                    Description = "Freedom postcard",
                    ImageUri = "../assets/images/freedom_belarus.jpg",
                    SourceLink = "https://www.instagram.com/ritabardak.art/",
                    AuthorName = "Marharita Tsikhanovich"
                },
                new PostCard
                {
                    Title = "Free Crowd",
                    Description = "Freedom postcard",
                    ImageUri = "../assets/images/crowd.jpg",
                    SourceLink = "https://www.instagram.com/ritabardak.art/",
                    AuthorName = "Marharita Tsikhanovich"
                },
            };
        }

        [HttpGet]
        public IEnumerable<PostCard> GetAllPostCards()
        {
            return _postCards;
        }

        [HttpGet]
        [Route("pictureFilePath")]
        public IActionResult GetImageByName(string pictureFilePath)
        {
            var fsReader = System.IO.File.OpenRead(pictureFilePath);
            return File(fsReader, "application/octet-stream", Path.GetFileName(pictureFilePath));
        }
    }
}
