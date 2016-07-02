using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class AccessTokenApiResponse : ApiResponseBase
    {
        public string AccessToken { get; set; }
        public int Expires_In { get; set; }
    }
}
