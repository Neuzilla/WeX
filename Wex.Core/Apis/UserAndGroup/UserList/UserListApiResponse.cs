using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class UserListApiResponse:ApiResponseBase
    {
        public int Total { get; set; }
        public int Count { get; set; }
        public OpenIdList Data { get; set; }
        public string Next_OpenId { get; set; }

        public class OpenIdList
        {
            public List<string> OpenId { get; set; }
        }
    }
}
