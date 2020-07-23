using FreeBelarus.Server.Builders;
using FreeBelarus.Shared.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public class JsonDeserializer<T> : IDeserializer<T> where T : IBusinessObject
    {
        private IBuilder _builder;

        public JsonDeserializer(IBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// Deserealizes business entity from json format
        /// </summary>
        /// <param name="content">Input string in JSON format</param>
        /// <returns>Business entity mapped from json</returns>
        public async Task<IEnumerable<T>> Deserialize(string content)
        {
            var jsonObject = await Task.Run(()=>JObject.Parse(content));
            return (IEnumerable<T>)_builder.Build(jsonObject);
        }
    }
}
