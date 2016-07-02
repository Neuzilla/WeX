using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class DeleteGroupApi : WeChatApiBase<SimpleApiResponse>, IDeleteGroupApi
    {
        public DeleteGroupApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }

        public override string Url
        {
            get { return "/cgi-bin/groups/delete"; }
        }

        public IJsonRequestContainer JsonData
        {
            get;
            set;
        }
    }
}
