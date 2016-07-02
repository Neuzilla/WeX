using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Neuzilla.Wex.Core.Messages.EventMessages
{
    public abstract class WeChatRequestEventMessageBase : WeChatRequestXmlMessageBase, IWeChatRequestEventMessage
    {

        public override WeChatRequestType MsgType
        {
            get { return WeChatRequestType.Event; }
        }
        [XmlIgnore]
        public abstract EventType Event
        {
            get;
        }
    }
}
