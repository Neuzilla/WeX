using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WexOne.OAMenus
{
    /// <summary>
    /// WeChat Official Account Menu API
    /// </summary>
    public interface IOAMenuService:IWeChatOAService
    {
        bool CreateMenu(IWeChatOAContext context, List<INamedMenuButton> buttons);
        string GetMenuJson(IWeChatOAContext context);
        bool DeleteMenu(IWeChatOAContext context);
    }
}
