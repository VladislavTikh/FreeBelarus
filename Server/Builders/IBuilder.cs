using FreeBelarus.Shared.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace FreeBelarus.Server.Builders
{
    /// <summary>
    /// Common interface for object's builders.
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// Return collection of business objects.
        /// </summary>
        /// <param name="jsonObject"></param>
        /// <returns>Collection of business objects.</returns>
        public IEnumerable<IBusinessObject> Build(JObject jsonObject);
    }
}
