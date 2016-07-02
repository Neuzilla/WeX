using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public class WeChatRequestShortVideoMessage : WeChatRequestVideoMessage
    {
        public override WeChatRequestType MsgType
        {
            get
            {
                return WeChatRequestType.ShortVideo;
            }
        }
    }
}
