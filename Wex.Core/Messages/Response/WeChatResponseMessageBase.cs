using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public abstract class WeChatResponseMessageBase:IWeChatResponseXmlMessage
    {
        public string ToUserName
        {
            get;
            set;
        }

        public string FromUserName
        {
            get;
            set;
        }

        public long CreateTime
        {
            get;
            set;
        }
        public abstract WeChatResponseType MsgType
        {
            get;
            set;
        }
    }
}
