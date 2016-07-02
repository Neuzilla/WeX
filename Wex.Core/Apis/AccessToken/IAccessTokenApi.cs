using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public interface IAccessTokenApi : IApi<AccessTokenApiResponse>
    {
        [QueryString("grant_type")]
        string GrantType { get; set; }
        [QueryString("appid")]
        string AppId { get; set; }
        [QueryString("secret")]
        string AppSecret { get; set; }
    }
}
