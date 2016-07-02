using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public interface IApiResponse
    {
        int errcode { get; set; }
        string errmsg { get; set; }
    }
}
