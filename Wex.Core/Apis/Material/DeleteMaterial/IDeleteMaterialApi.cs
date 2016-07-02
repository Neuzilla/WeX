using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public interface IDeleteMaterialApi : IWeChatApi<SimpleApiResponse>
    {
        [JsonProperty("media_id")]
        string MediaId { get; set; }
    }
}
