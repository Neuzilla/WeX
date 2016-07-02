using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public class WeChatRequestLocationMessage : WeChatRequestXmlMessageBase, IWeChatRequestNormalMessage
    {
        public long MsgId
        {
            get;
            set;
        }
        public override WeChatRequestType MsgType
        {
            get { return WeChatRequestType.Location; }
        }
        /// <summary>
        /// Latitude
        /// </summary>
        public double Location_X { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        public double Location_Y { get; set; }

        /// <summary>
        /// Map Scale
        /// </summary>
        public int Scale { get; set; }

        /// <summary>
        /// Location Label
        /// </summary>
        public string Label { get; set; }
    }
}
