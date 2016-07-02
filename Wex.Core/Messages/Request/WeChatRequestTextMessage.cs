using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public class WeChatRequestTextMessage : WeChatRequestXmlMessageBase, IWeChatRequestNormalMessage
    {
        public long MsgId
        {
            get;
            set;
        }
        public override WeChatRequestType MsgType
        {
            get
            {
                return WeChatRequestType.Text;
            }
        }
        /// <summary>
        /// text returned by the message
        /// </summary>
        public string Content
        {
            get;
            set;
        }
    }
}
