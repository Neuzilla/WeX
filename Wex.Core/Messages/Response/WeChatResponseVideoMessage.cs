using Neuzilla.Wex.Core.Messages.Response.MediaEntity;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    [SerializeAs(Name = "xml")]
    public class WeChatResponseVideoMessage:WeChatResponseMessageBase
    {
        public override WeChatResponseType MsgType
        {
            get { return WeChatResponseType.Voice; }
            set { }
        }
        public Video Video
        { 
            get; 
            set; 
        }
    }
}
