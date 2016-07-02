using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    interface IWeChatRequestNormalMessage:IWeChatRequestXmlMessage
    {
        /// <summary>
        /// WeChat message id
        /// </summary>
        long MsgId { get; set; }
    }
}
