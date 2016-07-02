using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    [SerializeAs(Name = "xml")]
    public class WeChatResponseTextMessage : WeChatResponseMessageBase
    {
        public override WeChatResponseType MsgType
        {
            get { return WeChatResponseType.Text; }
            set { }
        }
        /// <summary>
        /// text content
        /// </summary>
        public string Content 
        { 
            get; 
            set; 
        }
    }
}
