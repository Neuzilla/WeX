using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu
{
    public class MenuContainer : ITopMenu
    {
        [JsonProperty("button")]
        public List<INamedMenuButton> Buttons
        {
            get;
            set;
        }
        [JsonProperty("menuid")]
        public long MenuId { get; set; }
    }
}
