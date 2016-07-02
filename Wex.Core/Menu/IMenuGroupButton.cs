using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu
{
    public interface IMenuGroupButton:INamedMenuButton
    {
        /// <summary>
        /// length must be less than 5
        /// </summary>
        [JsonProperty("sub_button")]
        List<IMenuButton> SubButtons { get; set; }
    }
}
