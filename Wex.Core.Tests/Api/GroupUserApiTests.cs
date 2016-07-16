using Neuzilla.Wex.Core.Apis;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Tests.Api
{
    public class GroupUserApiTests:ApiTestBase
    {
        private int GetGroupId()
        {
            IGroupListApi api = new GroupListApi(context);
            var response = api.Execute();
            return response.Groups[3].Id;
        }

        [Test]
        public void TestMoveUsersToGroup()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void TestMoveUserToGroup()
        {
            IMoveUserToGroupApi api = new MoveUserToGroupApi(context);
            var jsonContainer = new MoveUserToGroupJsonDataContainer();
            jsonContainer.OpenId = GetOpenId();
            int targetgroupid=GetGroupId();
            jsonContainer.To_GroupId = targetgroupid;
            api.JsonData = jsonContainer;
            var response = api.Execute();

            IGroupUserBelongsToApi api2 = new GroupUserBelongsToApi(context);
            api2.JsonData = new GroupsUserBelongsToJsonDataContainer() { OpenId = GetOpenId() };
            var response2 = api2.Execute();
            Assert.AreEqual(targetgroupid, response2.GroupId);
        }
    }
}
