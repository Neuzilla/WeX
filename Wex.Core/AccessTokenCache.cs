using Neuzilla.Wex.Core.Apis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core
{
    public class AccessTokenCache
    {
        private static Dictionary<string, AccessToken> _accessTokens = new Dictionary<string, AccessToken>();

        public static string GetAccessToken(string appId, string appSerect)
        {
            if (!_accessTokens.ContainsKey(appId) || (_accessTokens.ContainsKey(appId) && _accessTokens[appId].IsExpired))
            {
                IAccessTokenApi api = new AccessTokenApi();
                api.AppId = appId;
                api.AppSecret = appSerect;
                var response = api.Execute();
                var newToken = new AccessToken();
                newToken.Value = response.AccessToken;
                newToken.ExpireTime = DateTime.Now.AddSeconds(response.Expires_In);
                newToken.AppId = appId;
                newToken.AppSecret = appSerect;
                if (!_accessTokens.ContainsKey(appId))
                {
                    _accessTokens.Add(appId, newToken);
                }
                else
                {
                    _accessTokens[appId]= newToken;
                }
            }
            return _accessTokens[appId].Value;
        }
    }
}
