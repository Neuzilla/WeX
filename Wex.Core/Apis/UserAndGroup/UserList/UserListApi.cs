using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class UserListApi:WeChatApiBase<UserListApiResponse>, IUserListApi
    {
        public UserListApi(IWeChatOAContext context):base(context)
        { 
            
        }

        public override string Url
        {
            get { return "/cgi-bin/user/get"; }
        }

        public string Next_OpenId
        {
            get;
            set;
        }
    }
}
