using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public interface IWeChatEncryptRequestMessage
    {
        /// <summary>
        /// encrypted string sent by WeChat
        /// </summary>
        /// <see cref="https://mp.weixin.qq.com/wiki/6/90f7259c0d0739bbb41d9f4c4c8e59a2.html"/>
        string Encrypt { get; set; }
    }
}
