using Neuzilla.Wex.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WexOne.OAUsers.Dto;

namespace WexOne.OAUsers
{
    public interface IOAUserService
    {
        string GetUserOpenId(IWeChatOAContext context,string nextOpenId);
        OAUserInfo GetUserInfo(IWeChatOAContext context, string openId, string language);
        List<string> GetUserList(IWeChatOAContext context);
        bool UpdateUserRemark(IWeChatOAContext context,string openId, string remark);
        int GetGroupIdUserBelongsTo(IWeChatOAContext context, string openId);
    }
}
