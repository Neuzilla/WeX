using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class MoveUsersToGroupApi : WeChatApiBase<SimpleApiResponse>, IMoveUsersToGroupApi
    {
        public MoveUsersToGroupApi(IWeChatOAContext context)
            : base(context)
        {

        }

        public override string Url
        {
            get { return "/cgi-bin/groups/members/batchupdate"; }
        }

        public IJsonRequestContainer JsonData
        {
            get;
            set;
        }
    }
}
