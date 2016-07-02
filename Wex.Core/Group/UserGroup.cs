using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Group
{
    public class UserGroup
    {
        /// <summary>
        /// Group Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Group name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// User count in the group
        /// </summary>
        public int Count { get; set; }
    }
}
