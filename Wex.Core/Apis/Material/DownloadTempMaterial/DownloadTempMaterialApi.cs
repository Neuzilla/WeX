using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis.Material
{
    public class DownloadTempMaterialApi : WeChatDownloadApiBase, IDownloadTempMaterialApi
    {
        public DownloadTempMaterialApi(IWeChatOAContext context)
            : base(context)
        {

        }
        public string MediaId { get; set; }

        public override string Url
        {
            get { return "/cgi-bin/media/get"; }
        }
    }
}
