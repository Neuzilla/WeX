using Neuzilla.Wex.Core.Messages.EventMessages;
using Neuzilla.Wex.Core.Utility;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Neuzilla.Wex.Core.Messages
{
    public class WeChatRequestEventMessageHandler
    {
        private WeChatRequestEventMessageHandler()
        { 
        
        }

        public static IWeChatRequestEventMessage Create(XDocument xdoc, string originalXmlMsg) 
        {
            
            var eventName = xdoc.Root.Element("Event").Value;
            switch(eventName.ToLower())
            {
                case "click":
                    return XmlSerializationHelper.DeserializeObject<ClickMenuButtonEventMessage>(new RestResponse(){Content=originalXmlMsg});
                case "location":
                    return XmlSerializationHelper.DeserializeObject<LocationReportEventMessage>(new RestResponse() { Content = originalXmlMsg });
                case "subscribe":
                    return XmlSerializationHelper.DeserializeObject<SubscribeEventMessage>(new RestResponse() { Content = originalXmlMsg });
                case "unsubscribe":
                    return XmlSerializationHelper.DeserializeObject<UnsubscribeEventMessage>(new RestResponse() { Content = originalXmlMsg });
                default:
                    throw new InvalidDataException("unknown event messge type, xml=" + originalXmlMsg);
            }

        }
    }
}
