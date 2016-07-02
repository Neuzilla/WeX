using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class DeleteMenuApi : WeChatApiBase<SimpleApiResponse>, IDeleteMenuApi
    {
        public DeleteMenuApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }

        public override string Url
        {
            get { return "/cgi-bin/menu/delete"; }
        }
    }
}
