using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class GenerateShortUrlApi: WeChatApiBase<GenerateShortUrlApiResponse>,IGenerateShortUrlApi
    {
        public GenerateShortUrlApi(IWeChatOAContext context)
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
            get { return "/cgi-bin/shorturl"; }
        }
    }
}
