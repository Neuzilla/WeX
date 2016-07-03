using Abp.Domain.Repositories;
using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Apis;
using Neuzilla.Wex.Core.Apis.Material;
using Neuzilla.Wex.Core.Messages;
using Neuzilla.Wex.Core.Messages.Response;
using Neuzilla.Wex.Core.Messages.EventMessages;
using Neuzilla.Wex.Core.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WexOne.Core;
using WexOne.Core.AzureStorage;
using Abp.Domain.Uow;

namespace WexOne.Web.Controllers
{
    [RoutePrefix("wechat")]
    public class WeChatController : WeChatControllerBase
    {
        Uri baseUri = new Uri(ConfigurationManager.AppSettings["HostUrl"]);

        public WeChatController()
        {
        }

        public async override Task<ActionResult> Index(string signature, string timestamp, string nonce, string echostr, string message)
        {
            if (!CheckSignature.Check(signature, timestamp, nonce, Token))
            {
                this.Logger.InfoFormat("signature:{0},timestamp:{1},nonce:{2}", signature, timestamp, nonce);
                Content("Error:101");
            }

            var requestMsg = WeChatRequestMessageFactory.Create(message, EncodingAESKey, AppId);
            if (requestMsg is WeChatRequestTextMessage)
            {
                //处理文本输入
                var request = requestMsg as WeChatRequestTextMessage;

                //处理URL文本
                var msg = new WeChatResponseTextMessage();
                msg.FromUserName = request.ToUserName;
                msg.ToUserName = request.FromUserName;
                msg.CreateTime = DateTimeHelper.NowForWeChat;
                msg.Content = "Hello World powered by Neuzilla Wex framework";

                return Content(msg.ToXml());
            }
            return Content("Error 200::unknown error");
        }
        //测试号
        public override string AppId
        {
            get { return "<your appid>"; }
        }

        public override string AppSecret
        {
            get { return "<your app serect>"; }
        }
        public override string EncodingAESKey
        {
            get { return "<your aes key>"; }
        }
    }
}