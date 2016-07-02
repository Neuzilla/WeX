using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    /// <summary>
    /// xml message sent from wechat server to your server
    /// </summary>
    public interface IWeChatResponseXmlMessage:IWeChatXmlMessage
    {
        WeChatResponseType MsgType { get; }
    }
}
