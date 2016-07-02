using Neuzilla.Wex.Core.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class GroupListApiResponse : ApiResponseBase
    {
        public List<UserGroup> Groups { get; set; }
    }

}
