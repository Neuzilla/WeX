using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Apis;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Tests.Api
{
    [TestFixture]
    public abstract class ApiTestBase
    {
        protected IWeChatOAContext context;

        protected string GetOpenId()
        {
            IUserListApi api = new UserListApi(context);
            var response = api.Execute();
            return response.Data.OpenId[0];
        }

        [SetUp]
        public void Setup()
        {
            context = new WeChatOAContext();
            context.AppId = ConfigurationManager.AppSettings["AppId"];
            context.AppSecret = ConfigurationManager.AppSettings["AppSecret"];
            string accesstoken = context.AccessToken;
        }
    }
}
