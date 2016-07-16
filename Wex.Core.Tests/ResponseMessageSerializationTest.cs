using Neuzilla.Wex.Core.Messages;
using Neuzilla.Wex.Core.Messages.Response.MediaEntity;
using Neuzilla.Wex.Core.Utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Neuzilla.Wex.Core.Tests
{
    [TestFixture]
    public class ResponseMessageSerializationTest
    {
        [Test]
        public void TestResponseTextMessageSerialization()
        {
            var msg = new WeChatResponseTextMessage();
            msg.FromUserName = "olPjZjsXuQPJoV0HlruZkNzKc91E";
            msg.ToUserName = "gh_a96a4a619366";
            var dt =new DateTime(2016, 3, 1, 12, 30, 11);
            msg.CreateTime = DateTimeHelper.ConvertToWeChatTimestamp(dt);
            msg.Content = "test";

            var xml=XmlSerializationHelper.SerializeObject(msg);
            Assert.IsNotNull(xml);

            using (StringReader s = new StringReader(xml))
            {
                XDocument result = XDocument.Load(s);
                Assert.AreEqual("xml", result.Root.Name.LocalName);
                Assert.AreEqual("test", result.Element("xml").Element("Content").Value);
                Assert.AreEqual("gh_a96a4a619366", result.Element("xml").Element("ToUserName").Value);
                Assert.AreEqual("olPjZjsXuQPJoV0HlruZkNzKc91E", result.Element("xml").Element("FromUserName").Value);
                Assert.AreEqual(dt, DateTimeHelper.ConvertFromWeChatTimeStamp(result.Element("xml").Element("CreateTime").Value));
            }
        }

        [Test]
        public void TestResponseImageMessageSerialization()
        {
            var msg = new WeChatResponseImageMessage();
            msg.FromUserName = "olPjZjsXuQPJoV0HlruZkNzKc91E";
            msg.ToUserName = "gh_a96a4a619366";
            var dt = new DateTime(2016, 3, 1, 12, 30, 11);
            msg.CreateTime = DateTimeHelper.ConvertToWeChatTimestamp(dt);
            msg.Image = new Image();
            msg.Image.MediaId = "test";

            var xml = XmlSerializationHelper.SerializeObject(msg);
            Assert.IsNotNull(xml);

            using (StringReader s = new StringReader(xml))
            {
                XDocument result = XDocument.Load(s);
                Assert.AreEqual("xml", result.Root.Name.LocalName);
                Assert.AreEqual("test", result.Element("xml").Element("Image").Element("MediaId").Value);
                Assert.AreEqual("gh_a96a4a619366", result.Element("xml").Element("ToUserName").Value);
                Assert.AreEqual("olPjZjsXuQPJoV0HlruZkNzKc91E", result.Element("xml").Element("FromUserName").Value);
                Assert.AreEqual(dt, DateTimeHelper.ConvertFromWeChatTimeStamp(result.Element("xml").Element("CreateTime").Value));
            }
        }

        [Test]
        public void TestResponseNewsMessageSerialization()
        {
            var msg = new WeChatResponseNewsMessage();
            msg.FromUserName = "olPjZjsXuQPJoV0HlruZkNzKc91E";
            msg.ToUserName = "gh_a96a4a619366";
            var dt = new DateTime(2016, 3, 1, 12, 30, 11);
            msg.CreateTime = DateTimeHelper.ConvertToWeChatTimestamp(dt);
            msg.Articles.Add(new Article()
            {
                Title = "Neuzilla 品牌介绍",
                Description = "Neuzilla作为上海芮石科技有限公司三大品牌之一，主营行业软件研发与定制服务、微信公众号开发、移动app开发、数据表单技术，条码及二维码生成及打印技术等",
                Url = "http://mp.weixin.qq.com/s?__biz=MzIzOTM1MDYzNw==&mid=100000006&idx=1&sn=3cb63f2ce51d0c706f68d699170284c5&scene=1&srcid=0511YBgNBu9N5bg2RSxjxNi9#rd",
                PicUrl = "https://mmbiz.qlogo.cn/mmbiz/wFDibJTSTzZ3bKghtg6Zgfulncb3jt3ZQCzfc7uCQ1Iia7N77YtrlJo8DtpEMKChibIIVGlzQyNLKjLtzjJlngTTA/0?wx_fmt=png"
            });

            var xml = XmlSerializationHelper.SerializeObject(msg);
            Assert.IsNotNull(xml);

            using (StringReader s = new StringReader(xml))
            {
                XDocument result = XDocument.Load(s);
                Assert.AreEqual("xml", result.Root.Name.LocalName);
                //Assert.AreEqual("test", result.Element("xml").Element("Image").Element("MediaId").Value);
                Assert.AreEqual("gh_a96a4a619366", result.Element("xml").Element("ToUserName").Value);
                Assert.AreEqual("olPjZjsXuQPJoV0HlruZkNzKc91E", result.Element("xml").Element("FromUserName").Value);
                Assert.AreEqual(dt, DateTimeHelper.ConvertFromWeChatTimeStamp(result.Element("xml").Element("CreateTime").Value));
            }
        }
    }
}
