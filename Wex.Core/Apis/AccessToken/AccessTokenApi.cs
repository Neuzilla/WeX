using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class AccessTokenApi:IAccessTokenApi
    {
        public AccessTokenApi()
        {
            this.GrantType = "client_credential";
        }

        public string GrantType
        {
            get;
            set;
        }

        public string AppId
        {
            get;
            set;
        }

        public string AppSecret
        {
            get;
            set;
        }

        public string Url
        {
            get { return "/cgi-bin/token"; }
        }


        public AccessTokenApiResponse Execute()
        {
            RequestBuilder<AccessTokenApiResponse> builder = new RequestBuilder<AccessTokenApiResponse>(this);
            var request=builder.GetRequest();
            var client = new RestClient(WeChatConsts.BaseUrl);
            var resp= client.Execute<AccessTokenApiResponse>(request);
            if (resp.ErrorException != null)
                throw new WeChatApiException(328001, resp.ErrorMessage);
            WeChatOAContext.CheckError(resp.Data);
            return resp.Data;
        }

        public string ExecuteRawContent()
        {
            throw new NotImplementedException();
        }
    }
}
