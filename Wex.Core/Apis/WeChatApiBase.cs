using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public abstract class WeChatApiBase<T> : IWeChatApi<T> where T:IApiResponse, new()
    {
        public WeChatApiBase()
        { 
        
        }

        public WeChatApiBase(IWeChatOAContext context)
        {
            this.Context = context;
        }

        public virtual string AccessToken
        {
            get { return Context.AccessToken; }
        }

        public IWeChatOAContext Context
        {
            get;
            set;
        }

        public abstract string Url
        {
            get;
        }

        public virtual T Execute()
        {
            RequestBuilder<T> builder = new RequestBuilder<T>(this);
            var request = builder.GetRequest();
            var client = new RestClient(WeChatConsts.BaseUrl);
            var resp = client.Execute<T>(request);
            if (resp.Data.errcode != 0)
                throw new WeChatApiException(resp.Data.errcode, resp.Data.errmsg);
            return resp.Data;
        }

        public string ExecuteRawContent()
        {
            RequestBuilder<T> builder = new RequestBuilder<T>(this);
            var request = builder.GetRequest();
            var client = new RestClient(WeChatConsts.BaseUrl);
            var resp = client.Execute(request);
            if (resp.ErrorException != null)
                throw resp.ErrorException;
            return resp.Content;
        }
    }
}
