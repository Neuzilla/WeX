using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace WexOne.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : WexOneControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}