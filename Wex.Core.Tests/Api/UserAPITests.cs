using Neuzilla.Wex.Core.Apis;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Tests.Api
{
    public class UserAPITests:ApiTestBase
    {
        [Test]
        public void TestGetUserList()
        {
            IUserListApi api = new UserListApi(context);
            var response = api.Execute();
            Assert.IsTrue(response.Total > 0);
            Assert.IsTrue(response.Count > 0);
            Assert.IsTrue(response.Data.OpenId.Count > 0);
            Assert.AreEqual(response.Data.OpenId[response.Data.OpenId.Count-1], response.Next_OpenId);
            Console.WriteLine(response.Data.OpenId[0]);
        }

        [Test]
        public void TestGetUserInfo()
        {
            IGetUserInfoApi api = new GetUserInfoApi(context);
            api.OpenId = GetOpenId();
            var response = api.Execute();
            Assert.AreEqual(1,response.Sex);    //男
            Assert.AreEqual("Tony Qu", response.Nickname);
            Assert.AreEqual("浦东新区", response.City);
            Assert.AreEqual("上海", response.Province);
            Assert.AreEqual("中国", response.Country);
            Assert.AreEqual("zh_CN", response.Language);
            Assert.IsTrue(response.HeadImgUrl.StartsWith("http://wx.qlogo.cn/"));
        }

        [Test]
        public void TestUpdateUserRemark()
        {
            string openid = GetOpenId(); 
            IUpdateUserRemarkApi api = new UpdateUserRemarkApi(context);
            var json = new UpdateUserRemarkJsonDataContainer();
            json.OpenId = openid;
            json.Remark = "Test1";
            api.JsonData = json;
            api.Execute();

            IGetUserInfoApi api2 = new GetUserInfoApi(context);
            api2.OpenId = openid;
            var result=api2.Execute();
            Assert.AreEqual("Test1", result.Remark);
        }
    }
}
