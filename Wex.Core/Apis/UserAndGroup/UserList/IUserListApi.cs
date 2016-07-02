using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public interface IUserListApi : IWeChatApi<UserListApiResponse>
    {
        [QueryString("next_openid")]
        string Next_OpenId { get; set; }
    }
}
