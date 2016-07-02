using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class UploadTempMediaApi : WeChatUploadFileApiBase<UploadTempMediaApiResponse>, IUploadTempMediaApi
    {
        public UploadTempMediaApi(IWeChatOAContext context)
            : base(context)
        { 
            
        }
        public UploadMediaType Type { get; set; }
        public string Media 
        {
            get {
                StringBuilder sb=new StringBuilder();
                if (this.FileName != null)
                    sb.AppendFormat("{0};", this.FileName);
                if(this.ContentType!=null)
                    sb.AppendFormat("{0};", this.ContentType);
                return sb.ToString();
            } 
        }

        public override string Url
        {
            get { return "/cgi-bin/media/upload"; }
        }
    }
}
