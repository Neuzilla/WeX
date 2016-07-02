using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class MoveUserToGroupApi : WeChatApiBase<SimpleApiResponse>, IMoveUserToGroupApi
    {
        public MoveUserToGroupApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }

        public override string Url
        {
            get { return "/cgi-bin/groups/members/update"; }
        }

        public IJsonRequestContainer JsonData
        {
            get;
            set;
        }
    }
}
