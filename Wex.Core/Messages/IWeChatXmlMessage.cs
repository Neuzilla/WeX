using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    /// <summary>
    /// Base interface for request and response xml message 
    /// </summary>
    public interface IWeChatXmlMessage
    {
        string ToUserName { get; set; }
        string FromUserName { get; set; }
        long CreateTime { get; set; }
    }
}
