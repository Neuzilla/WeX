using Neuzilla.Wex.Core.Group;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class GenerateShortUrlApiJsonContainer : IJsonRequestContainer
    {
        /// <summary>
        /// Group Name, less than 30 characters
        /// </summary>
        public string Action
        {
            get { return "long2short"; }
        }
        [JsonProperty("long_url")]
        public string LongUrl
        {
            get;set;
        }
    }
}
