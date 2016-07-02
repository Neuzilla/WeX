using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public abstract class WeChatDownloadApiBase : IWeChatApi<MemoryStream>
    {
        public WeChatDownloadApiBase()
        {

        }

        public WeChatDownloadApiBase(IWeChatOAContext context)
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


        public MemoryStream Execute()
        {
            RequestBuilder<MemoryStream> builder = new RequestBuilder<MemoryStream>(this);
            var request = builder.GetRequest();
            var client = new RestClient(WeChatConsts.BaseUrl);
            return new MemoryStream(client.DownloadData(request));
        }

        public string ExecuteRawContent()
        {
            throw new NotImplementedException();
        }
    }
}
