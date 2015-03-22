using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Servant.Shared.Objects
{
    public class WarmupResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Body { get; set; }
        public List<KeyValuePair<string, string>> Headers { get; set; }
    }
}