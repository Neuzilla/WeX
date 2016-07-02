using Neuzilla.Wex.Core.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class CreateGroupApi : WeChatApiBase<CreateGroupApiResponse>, ICreateGroupApi
    {
        public CreateGroupApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }

        public IJsonRequestContainer JsonData
        {
            get;
            set;
        }

        public override string Url
        {
            get { return "/cgi-bin/groups/create"; }
        }
    }
}
