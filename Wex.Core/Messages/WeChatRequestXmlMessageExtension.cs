using Neuzilla.Wex.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public static class WeChatResponseXmlMessageExtension
    {
        public static string ToXml(this IWeChatResponseXmlMessage msg)
        {
            return XmlSerializationHelper.SerializeObject(msg);
        }
    }
}
