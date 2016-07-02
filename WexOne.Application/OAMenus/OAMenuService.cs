using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Apis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WexOne.OAMenus
{
    public class OAMenuService:IOAMenuService
    {

        public bool CreateMenu(IWeChatOAContext context, List<Neuzilla.Wex.Core.Menu.INamedMenuButton> buttons)
        {
            ICreateMenuApi api = new CreateMenuApi(context);
            var jsonContainer = new CreateMenuApiJsonDataContainer();
            foreach (var button in buttons)
            {
                jsonContainer.Buttons.Add(button);
            }
            api.JsonData = jsonContainer;
            var response = api.Execute();
            return response.errcode == 0;
        }

        public string GetMenuJson(IWeChatOAContext context)
        {
            IGetMenuApi api = new GetMenuApi(context);
            var response = api.ExecuteRawContent();
            return response;
        }

        public bool DeleteMenu(IWeChatOAContext context)
        {
            IDeleteMenuApi api = new DeleteMenuApi(context);
            var response = api.Execute();
            return response.errcode == 0;
        }
    }
}
