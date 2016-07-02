using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class GetUserInfoApi : WeChatApiBase<GetUserInfoApiResponse>, IGetUserInfoApi
    {
        public GetUserInfoApi(IWeChatOAContext context)
        {
            this.Context = context;
        }

        public string OpenId
        {
            get;
            set;
        }

        public override string Url
        {
            get { return "/cgi-bin/user/info"; }
        }
    }
}
