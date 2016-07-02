using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core
{
    public class AccessToken
    {
        public string AppId 
        { 
            get; set; 
        }
        public string AppSecret
        {
            get;
            set;
        }
        public string Value 
        { 
            get; 
            set; 
        }

        public bool IsExpired 
        {
            get { return DateTime.Now > ExpireTime; }
        }

        public DateTime ExpireTime
        {
            get;
            set;
        }
    }
}
