using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class WeChatApiException:Exception
    {
        public WeChatApiException(int errorCode, string msg)
            : base(msg)
        {
            ErrorCode = errorCode;
        }

        public int ErrorCode { get; set; }
    }
}
