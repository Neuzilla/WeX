using Moq;
using Neuzilla.Wex.Core.Messages;
using Neuzilla.Wex.Core.Utility;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Tests
{
    [TestFixture]
    public class RequestMessageDeserializationTests
    {
        [Test]
        public void TestRequestTextMessageDeserialization()
        {
            string xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
                <xml>
                    <ToUserName><![CDATA[gh_a96a4a619366]]></ToUserName>
                    <FromUserName><![CDATA[olPjZjsXuQPJoV0HlruZkNzKc91E]]></FromUserName>
                    <CreateTime>1357986928</CreateTime>
                    <MsgType><![CDATA[text]]></MsgType>
                    <Content><![CDATA[TNT2]]></Content>
                    <MsgId>5832509444155992350</MsgId>
                </xml>
                ";

            var msg = XmlSerializationHelper.DeserializeObject<WeChatRequestTextMessage>(new RestResponse() { Content = xml });
            Assert.AreEqual("gh_a96a4a619366", msg.ToUserName);
            Assert.AreEqual("olPjZjsXuQPJoV0HlruZkNzKc91E", msg.FromUserName);
            Assert.AreEqual(1357986928, msg.CreateTime);
            Assert.AreEqual(5832509444155992350L, msg.MsgId);
            Assert.AreEqual("TNT2", msg.Content);
        }
        [Test]
        public void TestRequestLocalizationMessageDeserialization()
        {
            string xmlLocation = @"<?xml version=""1.0"" encoding=""utf-8""?>
                <xml>
                  <ToUserName><![CDATA[gh_a96a4a619366]]></ToUserName>
                  <FromUserName><![CDATA[olPjZjsXuQPJoV0HlruZkNzKc91E]]></FromUserName>
                  <CreateTime>1358061152</CreateTime>
                  <MsgType><![CDATA[location]]></MsgType>
                  <Location_X>31.285774</Location_X>
                  <Location_Y>120.597610</Location_Y>
                  <Scale>19</Scale>
                  <Label><![CDATA[中国江苏省苏州市沧浪区桐泾南路251号-309号]]></Label>
                  <MsgId>5832828233808572154</MsgId>
                </xml>";

            var msg = XmlSerializationHelper.DeserializeObject<WeChatRequestLocationMessage>(new RestResponse() { Content = xmlLocation });
            Assert.AreEqual("gh_a96a4a619366", msg.ToUserName);
            Assert.AreEqual("olPjZjsXuQPJoV0HlruZkNzKc91E", msg.FromUserName);
            Assert.AreEqual(1358061152, msg.CreateTime);
            Assert.AreEqual(5832828233808572154L, msg.MsgId);
            Assert.AreEqual(31.285774d, msg.Location_X);
            Assert.AreEqual(120.597610d, msg.Location_Y);
            Assert.AreEqual(19, msg.Scale);
            Assert.AreEqual("中国江苏省苏州市沧浪区桐泾南路251号-309号", msg.Label);
        }
        [Test]
        public void TestRequestImageMessageDeserialization()
        {
            string xmlImage = @"<?xml version=""1.0"" encoding=""utf-8""?>
            <xml><ToUserName><![CDATA[gh_5581465c968c]]></ToUserName> 
                <FromUserName><![CDATA[oGSJMwN2oH5D9mThhY92dSyKefAQ]]></FromUserName>
                <CreateTime>1459638032</CreateTime>
                <MsgType><![CDATA[image]]></MsgType>
                <PicUrl><![CDATA[http://mmbiz.qpic.cn/mmbiz/0C8cAKrnF3hUSsicicaW16hb1RYXCPOOYS9F3gHzkiapvCjUFRGNSHrFUD5qibc5Zp93gDzmUrTXM6q5RJ9ia3fUeLQ/0]]></PicUrl> 
                <MsgId>6269097611840223067</MsgId>
                <MediaId><![CDATA[gurOFf_4yyldsvTDh7VzMLbV3imHJn1THORHiciu3t5YTI2WqgkHMr6QsrPerDyx]]></MediaId> </xml>";

            var msg = XmlSerializationHelper.DeserializeObject<WeChatRequestImageMessage>(new RestResponse() { Content = xmlImage });
            Assert.AreEqual("gh_5581465c968c", msg.ToUserName);
            Assert.AreEqual("oGSJMwN2oH5D9mThhY92dSyKefAQ", msg.FromUserName);
            Assert.AreEqual(1459638032, msg.CreateTime);
            Assert.AreEqual(6269097611840223067L, msg.MsgId);
            Assert.AreEqual("gurOFf_4yyldsvTDh7VzMLbV3imHJn1THORHiciu3t5YTI2WqgkHMr6QsrPerDyx", msg.MediaId);
            Assert.AreEqual("http://mmbiz.qpic.cn/mmbiz/0C8cAKrnF3hUSsicicaW16hb1RYXCPOOYS9F3gHzkiapvCjUFRGNSHrFUD5qibc5Zp93gDzmUrTXM6q5RJ9ia3fUeLQ/0", msg.PicUrl);
        }
        [Test]
        public void TestRequestVoiceMessageDeserialization()
        {
            string xmlVoice = @"<?xml version=""1.0"" encoding=""utf-8""?>
            <xml>
              <ToUserName><![CDATA[gh_a96a4a619366]]></ToUserName>
              <FromUserName><![CDATA[olPjZjsXuQPJoV0HlruZkNzKc91E]]></FromUserName>
              <CreateTime>1361430302</CreateTime>
              <MsgType><![CDATA[voice]]></MsgType>
              <MediaId><![CDATA[X1yfgB2XI-faU6R2jmKz0X1JZmPCxIvM-9ktt4K92BB9577SCi41S-qMl60q5DJo]]></MediaId>
              <Format><![CDATA[amr]]></Format>
              <MsgId>5847298622973403529</MsgId>
            </xml>";

            var msg = XmlSerializationHelper.DeserializeObject<WeChatRequestVoiceMessage>(new RestResponse() { Content = xmlVoice });
            Assert.AreEqual("gh_a96a4a619366", msg.ToUserName);
            Assert.AreEqual("olPjZjsXuQPJoV0HlruZkNzKc91E", msg.FromUserName);
            Assert.AreEqual(1361430302, msg.CreateTime);
            Assert.AreEqual(5847298622973403529L, msg.MsgId);
            Assert.AreEqual("amr", msg.Format);
            Assert.AreEqual("X1yfgB2XI-faU6R2jmKz0X1JZmPCxIvM-9ktt4K92BB9577SCi41S-qMl60q5DJo", msg.MediaId);
        }
        [Test]
        public void TestRequestVideoMessageDeserialization()
        {
            string xmlVideo = @"<?xml version=""1.0"" encoding=""utf-8""?>
            <xml>
              <ToUserName><![CDATA[gh_a96a4a619366]]></ToUserName>
              <FromUserName><![CDATA[olPjZjsXuQPJoV0HlruZkNzKc91E]]></FromUserName>
              <CreateTime>1361430302</CreateTime>
              <MsgType><![CDATA[video]]></MsgType>
              <MediaId><![CDATA[mediaId]]></MediaId>
              <ThumbMediaId><![CDATA[thumbMediaId]]></ThumbMediaId>
              <MsgId>5847298622973403528</MsgId>
            </xml>";

            var msg = XmlSerializationHelper.DeserializeObject<WeChatRequestVideoMessage>(new RestResponse() { Content = xmlVideo });
            Assert.AreEqual("gh_a96a4a619366", msg.ToUserName);
            Assert.AreEqual("olPjZjsXuQPJoV0HlruZkNzKc91E", msg.FromUserName);
            Assert.AreEqual(WeChatRequestType.Video, msg.MsgType);
            Assert.AreEqual(1361430302, msg.CreateTime);
            Assert.AreEqual(5847298622973403528L, msg.MsgId);
            Assert.AreEqual("mediaId", msg.MediaId);
            Assert.AreEqual("thumbMediaId", msg.ThumbMediaId);
        }
        [Test]
        public void TestRequestShortVideoMessageDeserialization()
        {
            string xmlShortVideo = @"<?xml version=""1.0"" encoding=""utf-8""?>
            <xml>
              <ToUserName><![CDATA[gh_a96a4a619366]]></ToUserName>
              <FromUserName><![CDATA[olPjZjsXuQPJoV0HlruZkNzKc91E]]></FromUserName>
              <CreateTime>1361430302</CreateTime>
              <MsgType><![CDATA[video]]></MsgType>
              <MediaId><![CDATA[mediaId]]></MediaId>
              <ThumbMediaId><![CDATA[thumbMediaId]]></ThumbMediaId>
              <MsgId>5847298622973403528</MsgId>
            </xml>";

            var msg = XmlSerializationHelper.DeserializeObject<WeChatRequestShortVideoMessage>(new RestResponse() { Content = xmlShortVideo });
            Assert.AreEqual("gh_a96a4a619366", msg.ToUserName);
            Assert.AreEqual("olPjZjsXuQPJoV0HlruZkNzKc91E", msg.FromUserName);
            Assert.AreEqual(WeChatRequestType.ShortVideo, msg.MsgType);
            Assert.AreEqual(1361430302, msg.CreateTime);
            Assert.AreEqual(5847298622973403528L, msg.MsgId);
            Assert.AreEqual("mediaId", msg.MediaId);
            Assert.AreEqual("thumbMediaId", msg.ThumbMediaId);
        }
        [Test]
        public void TestRequestLinkMessageDeserialization()
        {
            string xmlLink = @"<?xml version=""1.0"" encoding=""utf-8""?>
            <xml>
            <ToUserName><![CDATA[gh_a96a4a619366]]></ToUserName>
            <FromUserName><![CDATA[olPjZjsXuQPJoV0HlruZkNzKc91E]]></FromUserName>
            <CreateTime>1351776360</CreateTime>
            <MsgType><![CDATA[link]]></MsgType>
            <Title><![CDATA[公众平台官网链接]]></Title>
            <Description><![CDATA[公众平台官网链接描述]]></Description>
            <Url><![CDATA[http://weixin.senparc.com]]></Url>
            <MsgId>1234567890123456</MsgId>
            </xml>";
            var msg = XmlSerializationHelper.DeserializeObject<WeChatRequestLinkMessage>(new RestResponse() { Content = xmlLink });
            Assert.AreEqual("gh_a96a4a619366", msg.ToUserName);
            Assert.AreEqual("olPjZjsXuQPJoV0HlruZkNzKc91E", msg.FromUserName);
            Assert.AreEqual(WeChatRequestType.Link, msg.MsgType);
            Assert.AreEqual(1351776360, msg.CreateTime);
            Assert.AreEqual("公众平台官网链接", msg.Title);
            Assert.AreEqual("公众平台官网链接描述", msg.Description);
            Assert.AreEqual("http://weixin.senparc.com", msg.Url);
            Assert.AreEqual(1234567890123456L, msg.MsgId);
        }
    }
}
