using System.Web.Mvc;

namespace WexOne.Web.Controllers
{
    public class AboutController : WexOneControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}