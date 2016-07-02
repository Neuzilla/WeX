using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class MoveUsersToGroupJsonDataContainer:IJsonRequestContainer
    {
        [JsonProperty("openid_list")]
        public List<string> OpenId_List { get; set; }

        [JsonProperty("to_groupid")]
        public string To_GroupId { get; set; }
    }
}
