using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class CallbackIPApi:WeChatApiBase<CallbackIPApiResponse>,ICallbackIPApi
    {
        public CallbackIPApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }

        public override string Url
        {
            get { return "/cgi-bin/getcallbackip"; }
        }
    }
}
