using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public class WeChatRequestVoiceMessage : WeChatRequestXmlMessageBase, IWeChatRequestNormalMessage
    {
        public long MsgId
        {
            get;
            set;
        }
        public override WeChatRequestType MsgType
        {
            get
            {
                return WeChatRequestType.Voice;
            }
        }
        /// <summary>
        /// Media id of the voice
        /// </summary>
        public string MediaId { get; set; }
        /// <summary>
        /// voice format,amr
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// Speech recognition result, utf8 encoding
        /// </summary>
        /// <remarks>
        /// Receive-speech-recognition-result（接受语音识别结果） feature must be enabled in interfaces authorization（接口权限）
        /// </remarks>s
        public string Recognition { get; set; }
    }
}
