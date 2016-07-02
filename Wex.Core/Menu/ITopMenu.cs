using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu
{
    /// <summary>
    /// top level button
    /// </summary>
    public interface ITopMenu
    {
        [JsonProperty("button")]
        List<INamedMenuButton> Buttons { get; set; }

    }
}
