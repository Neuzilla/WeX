using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Apis;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Tests.Api
{

    public class BasicApiTests:ApiTestBase
    {

        [Test]
        public void TestCallGetAccessTokenApi()
        {
            IAccessTokenApi api = new AccessTokenApi();
            api.AppId = "wx2821049fc9d4f632";
            api.AppSecret = "7abc65a7f37668be0ea87e1a7aae25b6";
            var response=api.Execute();
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.AccessToken);
            Assert.IsTrue(response.Expires_In > 0);
        }

        [Test]
        public void TestGetCallbackIPApi()
        {
            ICallbackIPApi api = new CallbackIPApi(context);
            var response = api.Execute();
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.IP_List);
            Assert.IsTrue(response.IP_List.Count>90);
        }

        [Test]
        public void TestGenerateShortUrlApi()
        {
            IGenerateShortUrlApi api = new GenerateShortUrlApi(context);
            api.JsonData = new GenerateShortUrlApiJsonContainer() { LongUrl = "http://blog.neuzilla.com" };
            var response = api.Execute();
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ShortUrl);
            Assert.IsTrue(response.ShortUrl.StartsWith("http://w.url.cn/s/"));
            Console.WriteLine(response.ShortUrl);
        }
    }
}
