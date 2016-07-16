using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Apis;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Tests.Api
{

    public class GroupApiTests:ApiTestBase
    {
        [Test]
        public void TestCreateGroupApi()
        {
            ICreateGroupApi api = new CreateGroupApi(context);
            var jsonContainer = new GroupApiJsonDataContainer();
            jsonContainer.Group = new Neuzilla.Wex.Core.Group.UserGroup(){ Name="test"};
            api.JsonData = jsonContainer;
            var response=api.Execute();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Group.Id>0);
            Assert.AreEqual("test",response.Group.Name);
            Assert.AreEqual(0, response.Group.Count);
        }
        [Test]
        public void TestGetGroupListApi()
        {
            IGroupListApi api = new GroupListApi(context);
            var response=api.Execute();
            Assert.IsTrue(response.Groups.Count > 3);
            Assert.AreEqual("未分组",response.Groups[0].Name);
            Assert.AreEqual("黑名单", response.Groups[1].Name);
            Assert.AreEqual("星标组", response.Groups[2].Name);
        }

        private void DeleteGroup(int id)
        {
            IDeleteGroupApi api2 = new DeleteGroupApi(context);
            var jsonContainer2 = new DeleteGroupJsonDataContainer();
            jsonContainer2.Group = new DeleteGroupJsonDataContainer.GroupWithId { Id = id };
            api2.JsonData = jsonContainer2;
            var response2 = api2.Execute();
        }

        private bool GroupExists(string name)
        {
            IGroupListApi api = new GroupListApi(context);
            var response = api.Execute();
            foreach (var group in response.Groups)
            {
                if (group.Name == name)
                    return true;
            }
            return false;
        }
        private bool GroupExists(int id)
        {
            IGroupListApi api = new GroupListApi(context);
            var response = api.Execute();
            foreach (var group in response.Groups)
            {
                if (group.Id==id)
                    return true;
            }
            return false;
        }
        private int CreateGroup(string name)
        {
            ICreateGroupApi api = new CreateGroupApi(context);
            var jsonContainer = new GroupApiJsonDataContainer();
            jsonContainer.Group = new Neuzilla.Wex.Core.Group.UserGroup() { Name = name};
            api.JsonData = jsonContainer;
            var response = api.Execute();
            return response.Group.Id;
        }
        [Test]
        public void TestRenameGroupApi()
        {
            int id = CreateGroup("test2");
            IRenameGroupApi api2 = new RenameGroupApi(context);
            var jsonContainer2 = new GroupApiJsonDataContainer();
            string renameTo="test2_modify";
            jsonContainer2.Group = new Neuzilla.Wex.Core.Group.UserGroup() { Id = id, Name= renameTo};
            api2.JsonData = jsonContainer2;
            var response2 = api2.Execute();

            Assert.IsTrue(GroupExists(renameTo));

            DeleteGroup(id);
        }
        private void ClearTestGroupsWithName(string name)
        { 
            IGroupListApi api = new GroupListApi(context);
            var response = api.Execute();
            foreach (var group in response.Groups)
            {
                if (group.Name == name)
                {
                    DeleteGroup(group.Id);
                }
            }
        }
        [Test]
        public void TestDeleteGroupApi()
        {
            Assert.IsFalse(GroupExists("test1"));
            int id = CreateGroup("test1");

            IDeleteGroupApi api2 = new DeleteGroupApi(context);
            var jsonContainer2 = new DeleteGroupJsonDataContainer();
            jsonContainer2.Group = new DeleteGroupJsonDataContainer.GroupWithId { Id = id };
            api2.JsonData = jsonContainer2;
            var response2 = api2.Execute();

            Assert.IsFalse(GroupExists(id));
        }
    }
}
