using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public interface IWeChatApi<T> : IApi<T>
    {
        [QueryString("access_token")]
        string AccessToken { get; }

        IWeChatOAContext Context { get; set; }
    }
}
