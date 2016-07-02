using Neuzilla.Wex.Core.Apis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core
{
    public class WeChatOAContext : IWeChatOAContext
    {
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        public string EncodingAESKey { get; set; }

        public string AccessToken
        {
            get
            {
                return AccessTokenCache.GetAccessToken(AppId, AppSecret);
            }
        }

        public static void CheckError(IApiResponse response)
        {
            if (response.errcode != 0)
                throw new WeChatApiException(response.errcode, response.errmsg);
        }
    }
}
