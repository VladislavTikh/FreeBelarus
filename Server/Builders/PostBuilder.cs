using FreeBelarus.Shared.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace FreeBelarus.Server.Builders
{
    public class PostBuilder : IBuilder
    {
        /// <summary>
        /// Returns collection of posts.
        /// </summary>
        /// <param name="jsonObject"></param>
        /// <returns>Collection of Posts mapped to json object.</returns>
        public IEnumerable<IBusinessObject> Build(JObject jsonObject)
        {
            var posts = new List<Post>();
            var dataSection = jsonObject["result"]["extractorData"]["data"];
            foreach(var node in dataSection[1]["group"].Children())
            {
                posts.Add(new Post
                {
                    Title = node["Media Block"][0]["text"].ToString(),
                    Content = node["Media Block"][0]["text"].ToString(),
                    SourceLink = node["Media Block"][0]["href"].ToString(),
                    ImageUri = node["Image Wraps Pac"][0]["src"].ToString(),
                    SourceName = node["Category Size"][0]["text"].ToString(),
                    Likes = 0
                });
            }
            return posts;
        }
    }
}
