using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Messages;
using Neuzilla.Wex.Core.Utility;
using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;
using WexOne.WeChat;
using WexOne.WeChat.Dto;

namespace WexOne.Web.Controllers
{
    [RoutePrefix("wechat")]
    public class WeChatController : WeChatControllerBase
    {
        Uri baseUri = new Uri(ConfigurationManager.AppSettings["HostUrl"]);
        readonly IWeChatEventLogAppService _eventLogService;
        public WeChatController(IWeChatEventLogAppService eventLogService)
        {
            _eventLogService = eventLogService;
        }

        public async override Task<ActionResult> Index(string signature, string timestamp, string nonce, string echostr, string message)
        {
            if (!CheckSignature.Check(signature, timestamp, nonce, Token))
            {
                this.Logger.InfoFormat("signature:{0},timestamp:{1},nonce:{2}", signature, timestamp, nonce);
                Content("Error:101");
            }

            var requestMsg = WeChatRequestMessageFactory.Create(message, EncodingAESKey, AppId);
            var eventLog = new CreateEventLogInput() {
                CreationTime = DateTime.Now,
                FromUserName = requestMsg.FromUserName,
                ToUserName = requestMsg.ToUserName,
                OriginalXml = message,
                MsgType=requestMsg.MsgType.ToString()
            };
            _eventLogService.CreateEventLog(eventLog);
            if (requestMsg is WeChatRequestTextMessage)
            {
                //处理文本输入
                var request = requestMsg as WeChatRequestTextMessage;

                //处理URL文本
                var msg = new WeChatResponseTextMessage();
                msg.FromUserName = request.ToUserName;
                msg.ToUserName = request.FromUserName;
                msg.CreateTime = DateTimeHelper.NowForWeChat;
                msg.Content = "Hello World powered by Neuzilla Wex framework"+WeChatEmotions.GetEmotion(WeChatEmotionType.Smile).SymbolCode;

                return Content(msg.ToXml());
            }
            else
            {
                var msg = new WeChatResponseTextMessage();
                msg.FromUserName = requestMsg.ToUserName;
                msg.ToUserName = requestMsg.FromUserName;
                msg.CreateTime = DateTimeHelper.NowForWeChat;
                msg.Content = "主人，我听不懂你在说什么"+WeChatEmotions.GetEmotion(WeChatEmotionType.Swear).SymbolCode;

                return Content(msg.ToXml());
            }
        }
        public override string AppId
        {
            get { return ConfigurationManager.AppSettings["AppId"]; }
        }

        public override string AppSecret
        {
            get { return ConfigurationManager.AppSettings["AppSecret"]; }
        }
        public override string EncodingAESKey
        {
            get { return ConfigurationManager.AppSettings["EncodingAESKey"]; }
        }
    }
}