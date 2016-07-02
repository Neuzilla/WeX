using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public class WeChatRequestImageMessage : WeChatRequestXmlMessageBase, IWeChatRequestNormalMessage
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
                return WeChatRequestType.Image;
            }
        }
        /// <summary>
        /// Media id of the image
        /// </summary>
        public string MediaId { get; set; }
        /// <summary>
        /// Image Url
        /// </summary>
        public string PicUrl { get; set; }
    }
}
