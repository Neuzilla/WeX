using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public abstract class WeChatUploadFileApiBase<T> : WeChatApiBase<T>, IUploadFileApi where T : IApiResponse, new()
    {
        public WeChatUploadFileApiBase(IWeChatOAContext context):base(context)
        { 
        
        }

        public override T Execute()
        {
            RequestBuilder<T> builder = new RequestBuilder<T>(this);
            var request = builder.GetRequest();
            if(ServerFilePath!=null)
                request.AddFile(FileName,ServerFilePath,ContentType);
            else
                request.AddFile(FileName, FileData, FileName, ContentType);
            var client = new RestClient(WeChatConsts.BaseUrl);
            var resp= client.Execute(request);   //wechat should return a json content with content-type application/json but it return text/plain
            JsonSerializer des = new JsonSerializer();
            using (StringReader reader = new StringReader(resp.Content))
            {
                T data = (T)des.Deserialize(reader, typeof(T));

                if (data.errcode != 0)
                    throw new WeChatApiException(data.errcode, data.errmsg);
                return data;
            }
        }

        public byte[] FileData { get; set; }

        public string ServerFilePath
        {
            get;
            set;
        }

        public string FileName
        {
            get;
            set;
        }

        public string ContentType
        {
            get;
            set;
        }
    }
}
