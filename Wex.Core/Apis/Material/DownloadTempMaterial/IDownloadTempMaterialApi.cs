using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis.Material
{
    public interface IDownloadTempMaterialApi : IWeChatApi<MemoryStream>
    {
        [QueryStringAttribute("media_id")]
        string MediaId { get; set; }
    }
}
