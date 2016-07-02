using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu
{
    public interface IViewMenuButton : IMenuButton
    {
        [JsonProperty("url",NullValueHandling = NullValueHandling.Ignore )]
        string Url { get; set; }
        [JsonProperty("media_id", NullValueHandling = NullValueHandling.Ignore)]
        string MediaId { get; set; }
    }
}
