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
    public class WeChatRequestMessageFactory
    {
        public static IWeChatRequestXmlMessage Create(string xmlmsg
            , string encodingAESKey
            , string appId)
        { 
            using (StringReader sr= new StringReader(xmlmsg))
            {
                var xml = XDocument.Load(sr);

                string decryptMsg = null;
                if (xml.Root.Element("Encrypt") != null)
                {
                    //encryption compatible mode is off
                    if (xml.Root.Element("MsgType") == null)
                    {
                        decryptMsg = Tencent.Cryptography.AES_decrypt(xml.Root.Element("Encrypt").Value, encodingAESKey, ref appId);
                        xmlmsg = decryptMsg;
                        xml = XDocument.Load(decryptMsg);
                    }
                    else
                    { 
                        //do nothing if encription compatible mode is on
                    }
                }

                return DeserializeMessage(xml, xmlmsg);
            }
        }
        private static IWeChatRequestXmlMessage DeserializeMessage(XDocument xml, string xmlMsg)
        {
            string msgType = xml.Root.Element("MsgType").Value;
            switch (msgType)
            {
                case "text":
                    return XmlSerializationHelper.DeserializeObject<WeChatRequestTextMessage>(new RestResponse() { Content = xmlMsg });
                case "image":
                    return XmlSerializationHelper.DeserializeObject<WeChatRequestImageMessage>(new RestResponse() { Content = xmlMsg });
                case "location":
                    return XmlSerializationHelper.DeserializeObject<WeChatRequestLocationMessage>(new RestResponse() { Content = xmlMsg });
                case "voice":
                    return XmlSerializationHelper.DeserializeObject<WeChatRequestVoiceMessage>(new RestResponse() { Content = xmlMsg });
                case "video":
                    return XmlSerializationHelper.DeserializeObject<WeChatRequestVideoMessage>(new RestResponse() { Content = xmlMsg });
                case "shortvideo":
                    return XmlSerializationHelper.DeserializeObject<WeChatRequestShortVideoMessage>(new RestResponse() { Content = xmlMsg });
                case "link":
                    return XmlSerializationHelper.DeserializeObject<WeChatRequestLinkMessage>(new RestResponse() { Content = xmlMsg });
                case "event":
                    return WeChatRequestEventMessageHandler.Create(xml, xmlMsg);
                default:
                    throw new InvalidDataException("unknown messge type:" + msgType);
            }
        }
    }
}
