using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages.Response.MediaEntity
{
    [SerializeAs(Name = "item")]
    public class Article
    {
        /// <summary>
        /// article title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// article description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// thumbnail url
        /// </summary>
        public string PicUrl { get; set; }
        /// <summary>
        /// article url
        /// </summary>
        public string Url { get; set; }
    }
}
