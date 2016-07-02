using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Neuzilla.Wex.Core
{
    public class XmlMessagePostAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContextBase httpContext = filterContext.HttpContext;
            //if (!httpContext.IsPostNotification)
            //{
            //    throw new InvalidOperationException("Only POST messages allowed on this resource");
            //}

            Stream httpBodyStream = httpContext.Request.InputStream;
            if (httpBodyStream.Length > int.MaxValue)
            {
                throw new ArgumentException("HTTP InputStream too large.");
            }

            StreamReader reader = new StreamReader(httpBodyStream, Encoding.UTF8);
            string xmlBody = reader.ReadToEnd();
            reader.Close();

            filterContext.ActionParameters["message"] = xmlBody;

            // Sends XML Data To Model so it could be available on the ActionResult
            base.OnActionExecuting(filterContext);
        }
    }
}
