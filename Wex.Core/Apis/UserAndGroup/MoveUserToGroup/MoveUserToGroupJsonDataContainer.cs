using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class MoveUserToGroupJsonDataContainer : SingleUserJsonDataContainer
    {
        [JsonProperty("to_groupid")]
        public int To_GroupId { get; set; }
    }
}
