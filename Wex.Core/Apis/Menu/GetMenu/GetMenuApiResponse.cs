using Neuzilla.Wex.Core.Group;
using Neuzilla.Wex.Core.Menu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{

    public class GetMenuApiResponse : ApiResponseBase
    {
        [JsonProperty("menu")]
        public MenuContainer Menu { get; set; }
    }
}
