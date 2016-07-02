using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class DeleteMaterialApi : WeChatApiBase<SimpleApiResponse>,IDeleteMaterialApi
    {
        public DeleteMaterialApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }
        [JsonProperty("media_id")]
        public string MediaId
        {
            get;
            set;
        }

        public override string Url
        {
            get { return "/cgi-bin/material/del_material"; }
        }
    }
}
