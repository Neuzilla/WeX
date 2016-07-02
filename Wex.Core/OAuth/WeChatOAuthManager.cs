using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.WX.Core.OAuth
{
    public class WeChatOAuthManager
    {
        public static string GenerateOAuthUrl(string appId, string redirectUrl,string state, OAuthScope scope)
        { 
            StringBuilder sb=new StringBuilder();
            sb.Append("https://open.weixin.qq.com/connect/oauth2/authorize?");
            sb.AppendFormat("appid={0}",appId);
            sb.AppendFormat("&redirect_uri={0}",redirectUrl);
            sb.Append("&response_type=CODE");
            sb.AppendFormat("&scope={0}",scope);
            sb.AppendFormat("&state={0}",state);
            sb.AppendFormat("#wechat_redirect",state);
            return sb.ToString();
        }
    }
}
