using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public class WeChatRequestVideoMessage : WeChatRequestXmlMessageBase, IWeChatRequestNormalMessage
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
                return WeChatRequestType.Video;
            }
        }
        /// <summary>
        /// Media id of the video
        /// </summary>
        public string MediaId { get; set; }
        /// <summary>
        /// Media id of the video's thumbnail
        /// </summary>
        public string ThumbMediaId { get; set; }
    }
}
