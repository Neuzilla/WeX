using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages.Response.MediaEntity
{
    public class Video:SimpleMedia
    {
        /// <summary>
        /// Video title
        /// </summary>
        public string Title 
        {
            get; 
            set; 
        }
        /// <summary>
        /// Video description
        /// </summary>
        public string Description 
        { 
            get; 
            set; 
        }
    }
}
