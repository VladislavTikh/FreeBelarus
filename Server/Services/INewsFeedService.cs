using FreeBelarus.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    /// <summary>
    /// Manipulate aggregated news resources in unified format.
    /// </summary>
    public interface INewsFeedService
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();
    }
}
