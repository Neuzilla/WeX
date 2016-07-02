using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class CreateMenuApi: WeChatApiBase<SimpleApiResponse>,ICreateMenuApi
    {
        public CreateMenuApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }

        public override string Url
        {
            get { return "/cgi-bin/menu/create"; }
        }

        public IJsonRequestContainer JsonData
        {
            get;
            set;
        }
    }
}
