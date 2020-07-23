using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    /// <summary>
    /// Crawls for data from different resources.
    /// </summary>
    public interface IWebCrawlerService
    {
        Task<string> GetJsonContentAsync();
    }
}