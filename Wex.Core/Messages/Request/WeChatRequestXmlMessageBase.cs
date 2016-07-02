using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public abstract class WeChatRequestXmlMessageBase : IWeChatRequestXmlMessage
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
        public string Encrypt 
        { 
            get; 
            set; 
        }

        public abstract WeChatRequestType MsgType
        {
            get;
        }
        
    }
}
