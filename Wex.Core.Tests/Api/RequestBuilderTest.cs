using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Apis;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Tests.Api
{
    [TestFixture]
    public class RequestBuilderTest
    {
        [Test]
        public void TestCreateRequestWithQueryString()
        {
            AccessTokenApi api = new AccessTokenApi();
            api.AppId = "wx2821049fc9d4f632";
            api.AppSecret = "7abc65a7f37668be0ea87e1a7aae25b6";
            RequestBuilder<AccessTokenApiResponse> builder = new RequestBuilder<AccessTokenApiResponse>(api);
            IRestRequest result=builder.GetRequest();
            Assert.AreEqual("/cgi-bin/token", result.Resource);
            Assert.AreEqual("client_credential",result.Parameters.Single(x=>x.Name=="grant_type").Value);
            Assert.AreEqual("wx2821049fc9d4f632", result.Parameters.Single(x => x.Name == "appid").Value);
            Assert.AreEqual("7abc65a7f37668be0ea87e1a7aae25b6", result.Parameters.Single(x => x.Name == "secret").Value);
        }
    }
}
