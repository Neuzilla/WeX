using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    /// <summary>
    /// WeChat link message
    /// </summary>
    public class WeChatRequestLinkMessage : WeChatRequestXmlMessageBase, IWeChatRequestNormalMessage
    {
        public long MsgId
        {
            get;
            set;
        }
        public override WeChatRequestType MsgType
        {
            get { return WeChatRequestType.Link; }
        }
        /// <summary>
        /// message title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// message description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// link url
        /// </summary>
        public string Url { get; set; }
    }
}
