using Neuzilla.Wex.Core.Messages.Response.MediaEntity;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    [SerializeAs(Name = "xml")]
    public class WeChatResponseNewsMessage:WeChatResponseMessageBase
    {
        public WeChatResponseNewsMessage()
        {
            this.Articles = new List<Article>();
        }
        /// <summary>
        /// article count
        /// </summary>
        public int ArticleCount
        {
            get
            {
                return Articles.Count;
            }
            private set
            { 
                
            }
        }

        public override WeChatResponseType MsgType
        {
            get { return WeChatResponseType.News; }
            set { }
        }
        /// <summary>
        /// article list
        /// </summary>
        public List<Article> Articles
        { 
            get; 
            set; 
        }

    }
}
