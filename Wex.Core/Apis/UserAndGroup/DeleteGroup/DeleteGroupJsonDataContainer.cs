using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class DeleteGroupJsonDataContainer:IJsonRequestContainer
    {
        public class GroupWithId
        {
            public int Id { get; set; }
        }
        public GroupWithId Group { get; set; }
    }
}
