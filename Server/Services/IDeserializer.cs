using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public interface IDeserializer<T>
    {
        Task<T> Deserialize(string content);
    }
}
