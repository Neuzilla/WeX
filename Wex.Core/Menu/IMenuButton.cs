using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu
{
    public interface IMenuButton:INamedMenuButton
    {
        /// <summary>
        /// menu type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        MenuButtonType Type { get; }
    }
}
