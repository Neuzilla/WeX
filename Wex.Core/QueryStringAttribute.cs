using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core
{
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryStringAttribute:Attribute
    {
        /// <summary>
        /// Api property should be used as a query string in the request
        /// </summary>
        public QueryStringAttribute(string aliasName)
        {
            this.AliasName = aliasName;
            this.ToLowerCase = false;
        }
        public QueryStringAttribute(string aliasName, bool toLowerCase)
        {
            this.AliasName = aliasName;
            this.ToLowerCase = true;
        }
        public bool ToLowerCase { get; set; }
        /// <summary>
        /// Real name in the request
        /// </summary>
        public string AliasName { get; set; }
    }
}
