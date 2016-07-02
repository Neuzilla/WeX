using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class GroupUserBelongsToApi : WeChatApiBase<GroupUserBelongsToApiResponse>, IGroupUserBelongsToApi
    {
        public GroupUserBelongsToApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }

        public override string Url
        {
            get { return "/cgi-bin/groups/getid"; }
        }

        public IJsonRequestContainer JsonData
        {
            get;
            set;
        }
    }
}
