using Neuzilla.Wex.Core.Apis;
using Neuzilla.Wex.Core.Menu.Buttons;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Tests.Api
{
    public class MenuApiTests:ApiTestBase
    {
        [Test]
        public void TestCreateMenuApiForProduction()
        {
            base.context.AppId = "wx19f2c832d0adfe65";
            base.context.AppSecret = "9070efa9140c8f1fc32828afddad5ee8";
            ICreateMenuApi api = new CreateMenuApi(context);
            var jsonContainer = new CreateMenuApiJsonDataContainer();
            var menugroup1 = new MenuGroupButton() { Name = "产品介绍" };
            menugroup1.SubButtons.Add(new ClickButton() { Name = "neuScan", Key = "qrcode_generation" });
            menugroup1.SubButtons.Add(new ClickButton() { Name = "neuPrint", Key = "realtime_print" });
            menugroup1.SubButtons.Add(new ClickButton() { Name = "neuForm", Key = "neuzilla_formassistant" });
            menugroup1.SubButtons.Add(new ClickButton() { Name = "关于Neuzilla", Key = "about_neuzilla" });
            jsonContainer.Buttons.Add(menugroup1);
            jsonContainer.Buttons.Add(new ViewUrlButton() { Name = "历史消息", Url = "http://mp.weixin.qq.com/mp/getmasssendmsg?__biz=MzIzOTM1MDYzNw==#wechat_webview_type=1&wechat_redirect" });

            jsonContainer.Buttons.Add(new ScancodePushButton() { Name = "扫一扫", Key = "scan_menu" });
            api.JsonData = jsonContainer;
            var response = api.Execute();
            Assert.IsNotNull(response);
            Assert.AreEqual(0, response.errcode);
        }

        [Test]
        public void TestCreateMenuApi()
        {
            ICreateMenuApi api = new CreateMenuApi(context);
            var jsonContainer = new CreateMenuApiJsonDataContainer();
            var menugroup1=new MenuGroupButton() { Name = "产品介绍" };
            menugroup1.SubButtons.Add(new ClickButton() { Name = "二维码实时生成", Key = "qrcode_generation" });
            menugroup1.SubButtons.Add(new ClickButton() { Name = "公众号实时打印技术", Key = "realtime_print" });
            menugroup1.SubButtons.Add(new ClickButton() { Name = "Neuzilla表单助手", Key = "neuzilla_formassistant" });
            menugroup1.SubButtons.Add(new ClickButton() { Name = "关于Neuzilla", Key = "about_neuzilla" });
            jsonContainer.Buttons.Add(menugroup1);
            jsonContainer.Buttons.Add(new ViewUrlButton() { Name = "历史消息", Url = "http://mp.weixin.qq.com/mp/getmasssendmsg?__biz=MzIzOTM1MDYzNw==#wechat_webview_type=1&wechat_redirect" });

            jsonContainer.Buttons.Add(new ScancodePushButton() { Name = "扫一扫", Key = "scan_menu" });
            api.JsonData = jsonContainer;
            var response = api.Execute();
            Assert.IsNotNull(response);
            Assert.AreEqual(0, response.errcode);
        }

        [Test]
        public void TestGetMenuApi()
        {
            ICreateMenuApi api = new CreateMenuApi(context);
            var jsonContainer = new CreateMenuApiJsonDataContainer();
            jsonContainer.Buttons.Add(new ViewUrlButton() { Name = "历史消息", Url = "http://mp.weixin.qq.com/mp/getmasssendmsg?__biz=MzIzOTM1MDYzNw==#wechat_webview_type=1&wechat_redirect" });
            api.JsonData = jsonContainer;
            api.Execute();

            IGetMenuApi api2 = new GetMenuApi(context);
            var response = api2.ExecuteRawContent();
            Assert.IsNotNull(response);
            Console.WriteLine(response);

            IDeleteMenuApi api3 = new DeleteMenuApi(context);
            api3.Execute();
        }

        [Test]
        public void TestDeleteMenuApi()
        {
            IDeleteMenuApi api = new DeleteMenuApi(context);
            var response = api.Execute();
            Assert.IsNotNull(response);
            Assert.AreEqual(0, response.errcode);
        }

    }
}
