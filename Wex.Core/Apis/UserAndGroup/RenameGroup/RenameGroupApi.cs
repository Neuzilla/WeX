using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class RenameGroupApi : WeChatApiBase<SimpleApiResponse>, IRenameGroupApi
    {
        public RenameGroupApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }

        public override string Url
        {
            get { return "/cgi-bin/groups/update"; }
        }

        public IJsonRequestContainer JsonData
        {
            get;
            set;
        }
    }
}
