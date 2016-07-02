using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class GetMenuApi : WeChatApiBase<GetMenuApiResponse>, IGetMenuApi
    {
        public GetMenuApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }
        public override string Url
        {
            get { return "/cgi-bin/menu/get"; }
        }
    }
}
