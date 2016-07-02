using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages.EventMessages
{
    /// <summary>
    /// event for click custom menu item
    /// </summary>
    public class UnsubscribeEventMessage : WeChatRequestEventMessageBase
    {
        public override EventType Event
        {
            get { return EventType.unsubscribe; }
        }
    }
}
