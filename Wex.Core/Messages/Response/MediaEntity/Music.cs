using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    public class Music
    {
        /// <summary>
        /// music title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// music description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// music url
        /// </summary>
        public string MusicUrl { get; set; }
        /// <summary>
        /// hd music url, this music will be played in priority if WIFI is available
        /// </summary>
        public string HQMusicUrl { get; set; }
        /// <summary>
        /// Media id of the thumbnail
        /// </summary>
        public string ThumbMediaId { get; set; }
    }
}
