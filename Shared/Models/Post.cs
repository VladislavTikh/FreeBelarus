using System;
using System.Collections.Generic;
using System.Text;

namespace FreeBelarus.Shared.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Published { get; set; }
        public string SourceLink { get; set; }
        public string SourceName { get; set; }
        public int Likes { get; set; }
    }
}
