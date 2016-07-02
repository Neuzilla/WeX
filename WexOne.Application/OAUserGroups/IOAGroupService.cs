using Neuzilla.Wex.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WexOne.OAUserGroups.Dto;
using WexOne.OAUsers.Dto;

namespace WexOne.OAUserGroups
{
    public interface IOAGroupService
    {
        bool DeleteGroup(IWeChatOAContext context,int groupId);
        bool RenameGroup(IWeChatOAContext context, int groupId,string name);
        UserGroup CreateGroup(IWeChatOAContext context, int groupId);
        List<UserGroup> GetGroupList(IWeChatOAContext context);
        bool GroupExists(IWeChatOAContext context, string name);
    }
}
