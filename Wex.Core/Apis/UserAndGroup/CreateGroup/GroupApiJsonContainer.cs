using Neuzilla.Wex.Core.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class GroupApiJsonDataContainer : IJsonRequestContainer
    {
        /// <summary>
        /// Group Name, less than 30 characters
        /// </summary>
        public UserGroup Group
        {
            get;
            set;
        }
    }
}
