using Neuzilla.Wex.Core.Apis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core
{
    public interface IWeChatOAContext
    {
        string AppId { get; set; }
        string AppSecret { get; set; }
        string AccessToken { get;  }

        string EncodingAESKey { get; set; }
    }
}
