using MessagingToolkit.QRCode.Codec;
using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Apis;
using Neuzilla.Wex.Core.Messages;
using Neuzilla.Wex.Core.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace WexOne.Web.Controllers
{
    public abstract class WeChatControllerBase : WexOneControllerBase
    {
        public abstract string AppId { get; }
        public abstract string AppSecret { get; }
        public abstract string EncodingAESKey { get; }

        protected IWeChatOAContext Context
        {
            get
            {
                IWeChatOAContext context = new WeChatOAContext();
                context.AppId = this.AppId;
                context.AppSecret = this.AppSecret;
                context.EncodingAESKey = this.EncodingAESKey;
                return context;
            }
        }

        protected string Token
        { 
            get
            {
                return ConfigurationManager.AppSettings["Token"] == null ? WeChatConsts.DefaultToken : ConfigurationManager.AppSettings["Token"];
            }
        }
        [Route("")]
        public async Task<ActionResult> Index(string signature, string timestamp, string nonce, string echostr)
        {
            if (CheckSignature.Check(signature, timestamp, nonce, Token))
            {
                return Content(echostr); 
            }
            else
            {
                this.Logger.InfoFormat("signature:{0},timestamp:{1},nonce:{2}", signature, timestamp, nonce);

                return Content("Error 100");
            }
        }
        protected void LogMessageXml(string xml)
        {
            this.Logger.Info("msgxml: " + xml);
        }
        [Route("")]
        [HttpPost]
        [XmlMessagePost]
        public abstract Task<ActionResult> Index(string signature, string timestamp, string nonce, string echostr, string message);
    }
}