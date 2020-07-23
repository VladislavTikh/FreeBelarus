using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public interface IDeserializer<T>
    {
        Task<IEnumerable<T>> Deserialize(string content);
    }
}
