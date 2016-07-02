using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class ApiResponseBase:IApiResponse
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
