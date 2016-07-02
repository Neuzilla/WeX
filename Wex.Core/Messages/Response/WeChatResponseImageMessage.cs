using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    [SerializeAs(Name = "xml")]
    public class WeChatResponseImageMessage:WeChatResponseMessageBase
    {
        public override WeChatResponseType MsgType
        {
            get { return WeChatResponseType.Image; }
            set { }
        }
        public Image Image 
        { 
            get; 
            set; 
        }
    }
}
