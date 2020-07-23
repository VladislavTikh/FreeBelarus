namespace FreeBelarus.Shared.Models
{
    public class PostCard : IBusinessObject
    {
        public string Description { get; set; }

        public string ImageUri { get; set; }

        public string Title { get; set; }

        public string SourceLink { get; set; }

        public string AuthorName { get; set; }

        public string DownloadLink { get; set; }
    }
}
