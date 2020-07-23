using System;

namespace FreeBelarus.Shared.Models
{
    public class Post : IBusinessObject
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUri { get; set; }
        public DateTime Published { get; set; }
        public string SourceLink { get; set; }
        public string SourceName { get; set; }
        public int Likes { get; set; }
    }
}
