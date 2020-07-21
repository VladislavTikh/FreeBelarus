using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public class JsonDeserializer<T> : IDeserializer<T>
    {
        public Task<T> Deserialize(string content)
        {
            throw new NotImplementedException();
        }
    }
}
